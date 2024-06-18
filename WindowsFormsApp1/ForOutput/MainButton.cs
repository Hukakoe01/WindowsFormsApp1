using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1.bd;
// это программа отвечает за перевод валют

namespace WindowsFormsApp1.ForOutput
{
    internal class MainButton
    {
        private string first_value_from_api;
        private string second_value_from_api;
        private string box_much_value;
        private string userName;
        private RichTextBox window_for_user_output;

        public MainButton(string firstValue, string secondValue, string boxMuchValue, string userName, RichTextBox outputTextBox)
        {
            first_value_from_api = firstValue;
            second_value_from_api = secondValue;
            box_much_value = boxMuchValue;
            this.userName = userName;
            window_for_user_output = outputTextBox;
        }

        public async Task ProcessAsync()
        {
            string apiKey = ""; // ваш API ключ
            string endpoint = $"https://currencyapi.net/api/v1/rates?key={apiKey}&output=JSON";

            try
            {
                // проверка на наличие введённых валют
                if (first_value_from_api == "ваша валюта") { MessageBox.Show("выберите валюту"); return; }
                if (second_value_from_api == "в какую переводить") { MessageBox.Show("выберите валюту"); return; }

                using (HttpClient client = new HttpClient())
                {
                    // отправка запроса к api
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    // проверка на успешность запроса
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<CurrencyApiResponse>(responseBody);

                        if (data != null && data.Rates.ContainsKey(first_value_from_api) && data.Rates.ContainsKey(second_value_from_api))
                        {
                            if (float.TryParse(box_much_value, out float parametr))
                            {
                                // получение ценового эквивалента валюты
                                float val1 = (float)data.Rates[first_value_from_api];
                                float val2 = (float)data.Rates[second_value_from_api];
                                // расчёт перевода
                                float itog = parametr / val1 * val2;
                                DateTime currentTime = DateTime.Now;
                                // вывод сообщения в поле 
                                window_for_user_output.Text += $"\n{currentTime}\nКурс {first_value_from_api} к {second_value_from_api}: {parametr} {first_value_from_api} = {itog} {second_value_from_api}";

                                using (var context = new ApplicationDbContext())
                                {
                                    // получение актуального юзера
                                    var user = context.Users.FirstOrDefault(u => u.Name == userName);
                                    // если юзер новый, то создание нового
                                    if (user == null)
                                    {
                                        // новый юзер
                                        user = new User { Name = userName };
                                        // добавление его в базу данных
                                        context.Users.Add(user);
                                    }
                                    // добавление новой строчки таблицы запроса
                                    var query = new Query
                                    {
                                        ValueFrom = first_value_from_api,
                                        ValueTo = second_value_from_api,
                                        DateTime = currentTime,
                                        User = user,
                                        ValueToConvert = parametr
                                    };
                                    context.Queries.Add(query);
                                    // добавление новой строчки таблицы результатов
                                    var queryResult = new QueryResult
                                    {
                                        Value1 = val1,
                                        Value2 = val2,
                                        DateTime = currentTime,
                                        Query = query,
                                        Itogo = itog
                                    };
                                    context.QueryResults.Add(queryResult);
                                    // сохранение изменений
                                    context.SaveChanges();
                                }
                            }
                            else
                            {
                                MessageBox.Show("error: input true integer value in how_much_value.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("error: no such files for selected value.");
                        }
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"error request: {response.StatusCode}\n{errorResponse}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Request error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message);
            }
        }
    }
}
