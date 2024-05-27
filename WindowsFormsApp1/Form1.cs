using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string UserDbFileName = "user_currency.db";
        private const string RatesDbFileName = "rates_currency.db";
        private string userConnectionString;
        private string ratesConnectionString;

        public Form1()
        {
            InitializeComponent();
            toolStripTextBox2.Text = "";
            toolStripTextBox3.Text = "";
            userConnectionString = $"Data Source={UserDbFileName};Version=3;";
            ratesConnectionString = $"Data Source={RatesDbFileName};Version=3;";
            CreateUserDatabaseIfNotExists();
            CreateRatesDatabaseIfNotExists();

            textBox1.TextChanged += textBox1_TextChanged;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                LoadUserData(textBox1.Text);
            }
        }

        private void CreateUserDatabaseIfNotExists()
        {
            if (!File.Exists(UserDbFileName))
            {
                SQLiteConnection.CreateFile(UserDbFileName);
                using (var connection = new SQLiteConnection(userConnectionString))
                {
                    connection.Open();
                    string createTableQuery = "CREATE TABLE Currency (Id INTEGER PRIMARY KEY AUTOINCREMENT, nameuser TEXT, texttextbox1 TEXT, UNIQUE(nameuser))";
                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void CreateRatesDatabaseIfNotExists()
        {
            if (!File.Exists(RatesDbFileName))
            {
                SQLiteConnection.CreateFile(RatesDbFileName);
                using (var connection = new SQLiteConnection(ratesConnectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS CurrencyRates (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Time TIMESTAMP,
                            Value REAL,
                            Currency TEXT
                        )";
                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        string a = "RUB";
        string b = "AED";

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiKey = "AQ7WdO9YzqlEbMpFkZttjm6aypq0obavloba";
            string endpoint = $"https://currencyapi.net/api/v1/rates?key={apiKey}&output=JSON";

            try
            {
                if (toolStripTextBox2.Text != "") { a = toolStripTextBox2.Text; }
                if (toolStripTextBox3.Text != "") { b = toolStripTextBox3.Text; }

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrencyApiResponse>(responseBody);
                        if (data != null && data.Rates.ContainsKey(a) && data.Rates.ContainsKey(b))
                        {
                            if (float.TryParse(toolStripTextBox1.Text, out float parametr))
                            {
                                float val1 = (float)data.Rates[a];
                                float val2 = (float)data.Rates[b];

                                float itog = parametr / val1 * val2;
                                DateTime currentTime = DateTime.Now;

                                richTextBox1.Text += $"\n{currentTime}\nКурс {a} к {b}: {parametr} {a} = {itog} {b}";
                                SaveUserData(textBox1.Text, richTextBox1.Text);

                                SaveCurrencyValue(currentTime, val1, a);
                                SaveCurrencyValue(currentTime, val2, b);
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: Введите корректное числовое значение в toolStripTextBox1.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка: Не найдены данные для выбранных валют.");
                        }
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Ошибка запроса: {response.StatusCode}\n{errorResponse}");
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

        private void SaveCurrencyValue(DateTime time, float value, string currency)
        {
            using (var connection = new SQLiteConnection(ratesConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO CurrencyRates (Time, Value, Currency) VALUES (@time, @value, @currency)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@time", time);
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@currency", currency);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void SaveUserData(string username, string text)
        {
            using (var connection = new SQLiteConnection(userConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Currency (nameuser, texttextbox1) VALUES (@nameuser, @texttextbox1) " +
                               "ON CONFLICT(nameuser) DO UPDATE SET texttextbox1 = excluded.texttextbox1";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nameuser", username);
                    command.Parameters.AddWithValue("@texttextbox1", text);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadUserData(string username)
        {
            using (var connection = new SQLiteConnection(userConnectionString))
            {
                connection.Open();
                string query = "SELECT texttextbox1 FROM Currency WHERE nameuser = @nameuser";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nameuser", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            richTextBox1.Text = reader.GetString(0);
                        }
                        else
                        {
                            richTextBox1.Text = "";
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                LoadUserData(textBox1.Text);
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void рубльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "RUB";
        }

        private void долорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "USD";
        }

        private void евроToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "EUR";
        }

        private void белорусскийРубльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = "EOS";
        }

        private void рубльToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            b = "RUB";
        }

        private void долорToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            b = "USD";
        }

        private void евроToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            b = "EUR";
        }

        private void белоруссToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = "EOS";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            LoadCurrencyValuesForDate(selectedDate);
        }

        private void LoadCurrencyValuesForDate(DateTime date)
        {
            using (var connection = new SQLiteConnection(ratesConnectionString))
            {
                connection.Open();
                string query = "SELECT Time, Value, Currency FROM CurrencyRates WHERE DATE(Time) = DATE(@date)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    using (var reader = command.ExecuteReader())
                    {
                        richTextBox2.Clear();
                        while (reader.Read())
                        {
                            DateTime time = reader.GetDateTime(0);
                            float value = reader.GetFloat(1);
                            string currency = reader.GetString(2);
                            richTextBox2.AppendText($"{time}: {currency}: {value}\n");
                        }
                    }
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
