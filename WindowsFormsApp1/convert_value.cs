using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Program_for_value
{
    public partial class convert_value : Form
    {
        //загрузка формы
        public convert_value()
        {
            InitializeComponent();
            value_in.Text = "";
            value_out.Text = "";

            // Инициализация базы данных
            using (var context = new ApplicationDbContext())
            {
                if (!context.Database.CanConnect())
                {
                    context.Database.Migrate();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// присваивание базовой валюты
        /// </summary>
        string first_value_from_api = "RUB";
        /// <summary>
        /// присваивание второй базовой валюты
        /// </summary>
        string second_value_from_api = "USD";

        private async void button1_Click(object sender, EventArgs e)
        {
            //создание адреса запроса api
            string apiKey = "";
            string endpoint = $"https://currencyapi.net/api/v1/rates?key={apiKey}&output=JSON";

            try
            {
                //проверка на наличие введённых валют в поля для ввода своих валют
                if (!string.IsNullOrEmpty(value_in.Text)) { first_value_from_api = value_in.Text; }
                if (!string.IsNullOrEmpty(value_out.Text)) { second_value_from_api = value_out.Text; }

                using (HttpClient client = new HttpClient())
                {
                    //отправка запроса к api
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    //проверка на успешность запроса
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrencyApiResponse>(responseBody);

                        if (data != null && data.Rates.ContainsKey(first_value_from_api) && data.Rates.ContainsKey(second_value_from_api))
                        {
                            if (float.TryParse(how_much_value.Text, out float parametr))
                            {
                                //получение ценового эквивалента валюты
                                float val1 = (float)data.Rates[first_value_from_api];
                                float val2 = (float)data.Rates[second_value_from_api];
                                //расчёт перевода
                                float itog = parametr / val1 * val2;
                                DateTime currentTime = DateTime.Now;
                                //вывод сообщения в поле 
                                window_for_user_output.Text += $"\n{currentTime}\nКурс {first_value_from_api} к {second_value_from_api}: {parametr} {first_value_from_api} = {itog} {second_value_from_api}";

                                using (var context = new ApplicationDbContext())
                                {
                                    //получение актуального юзера
                                    var user = context.Users.FirstOrDefault(u => u.Name == textBox1.Text);
                                    //если юзер новый то создание нового
                                    if (user == null)
                                    {
                                        //новый юзер
                                        user = new User { Name = textBox1.Text };
                                        //добавление его в базу данных
                                        context.Users.Add(user);
                                    }
                                    //добавление новой строчки таблицы запроса
                                    var query = new Query
                                    {
                                        ValueFrom = first_value_from_api,
                                        ValueTo = second_value_from_api,
                                        DateTime = currentTime,
                                        User = user,
                                        ValueToConvert = parametr
                                    };
                                    context.Queries.Add(query);
                                    //добавление новой строчки таблицы результатов
                                    var queryResult = new QueryResult
                                    {
                                        Value1 = val1,
                                        Value2 = val2,
                                        DateTime = currentTime,
                                        Query = query,
                                        Itogo = itog
                                    };
                                    context.QueryResults.Add(queryResult);
                                    //сохранение изменений
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
        //дальше идёт много команд отвечающих за выбор валюты перевода откуда и куда
        private void RUBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            first_value_from_api = "RUB";
        }

        private void USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            first_value_from_api = "USD";
        }

        private void EURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            first_value_from_api = "EUR";
        }

        private void EOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            first_value_from_api = "EOS";
        }

        private void RUBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            second_value_from_api = "RUB";
        }

        private void USDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            second_value_from_api = "USD";
        }

        private void EURToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            second_value_from_api = "EUR";
        }

        private void EOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            second_value_from_api = "EOS";
        }
        /// <summary>
        /// данная команда отвечает за вывод информации по актуальной дате
        /// </summary>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //выбор даты
            DateTime selectedDate = e.Start;
            using (var context = new ApplicationDbContext())
            {
                //выбор потходящих данных по актуальной дате
                var queries = context.Queries.Include(q => q.QueryResults)
                                             .Where(q => q.DateTime.Date == selectedDate.Date)
                                             .ToList();
                //удаление старого содержания
                window_for_output_by_date.Clear();
                foreach (var query in queries)
                {
                    foreach (var result in query.QueryResults)
                    {
                        //вывод курса валют по актуальной дате
                        window_for_output_by_date.AppendText($"{result.DateTime}\n" +
                                                $" {query.ValueFrom} : {result.Value1}\n" +
                                                $" {query.ValueTo} : {result.Value2}\n\n");
                    }
                }
            }
        }

        //обработка поля для ввода имя
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    //выбор пльзователя
                    var user = context.Users
                                       .Include(u => u.Queries)
                                       .ThenInclude(q => q.QueryResults)
                                       .FirstOrDefault(u => u.Name == textBox1.Text);

                    window_for_user_output.Clear();
                    if (user != null)
                    {
                        // Цикл по всем запросам пользователя
                        foreach (var query in user.Queries)
                        {
                            // Цикл по всем результатам каждого запроса
                            foreach (var result in query.QueryResults)
                            {
                                window_for_user_output.AppendText($"ValueFrom: {query.ValueFrom}, ValueTo: {query.ValueTo}, ValueToConvert: {query.ValueToConvert}\n");
                                window_for_user_output.AppendText($"DateTime: {result.DateTime}, Itogo: {result.Itogo}\n\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General error: " + ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                    }
                }
            }
        }


        public class CurrencyApiResponse
        {
            public string Base { get; set; }
            public string Output { get; set; }
            public Dictionary<string, double> Rates { get; set; }
        }
    }
    //создание таблицы пользователей
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Query> Queries { get; set; } = new List<Query>();
    }
    //создание таблицы с информацией из запроса
    public class Query
    {
        public int Id { get; set; }
        public string ValueFrom { get; set; }
        public string ValueTo { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public float ValueToConvert { get; set; }
        public List<QueryResult> QueryResults { get; set; } = new List<QueryResult>();
    }
    // создание таблицы с выводом
    public class QueryResult
    {
        public int Id { get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public DateTime DateTime { get; set; }
        public int QueryId { get; set; }
        public Query Query { get; set; }
        public float Itogo { get; set; }
    }

    
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<QueryResult> QueryResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //выбор базы данных с которой идёт работа
            optionsBuilder.UseSqlite("Data Source=database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Вызываем метод OnModelCreating
            base.OnModelCreating(modelBuilder);

            // Определяем ключ для User
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            // Определяем первичный ключ Query
            modelBuilder.Entity<Query>().HasKey(q => q.Id);

            // Определяем первичный ключом для QueryResult
            modelBuilder.Entity<QueryResult>().HasKey(qr => qr.Id);

            // Настраиваем связь один-ко-многим между Query и User
            modelBuilder.Entity<Query>()
                .HasOne(q => q.User)
                .WithMany(u => u.Queries)    
                .HasForeignKey(q => q.UserId); 

            // Настраиваем связь один-ко-многим между QueryResult и Query
            modelBuilder.Entity<QueryResult>()
                .HasOne(qr => qr.Query)        
                .WithMany(q => q.QueryResults)  
                .HasForeignKey(qr => qr.QueryId);

        }
    }
}
