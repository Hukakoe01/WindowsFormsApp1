using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.bd;
using WindowsFormsApp1.ForOutput;
using WindowsFormsApp1.workWithName;
// это основная программа из которой идёт запуск остальных

namespace Program_for_value
{
    public partial class convert_value : Form
    {
        //загрузка формы
        public convert_value()
        {
            InitializeComponent();

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
    
        private async void button1_Click(object sender, EventArgs e)
        {
            // создание экземпляра класса MainButton и вызов метода
            MainButton mainButton = new MainButton(
                box_for_in_value.Text,
                box_for_out_value.Text,
                box_much_value.Text,
                textBox1.Text,
                window_for_user_output);
            await mainButton.ProcessAsync();
        }
        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            OutputByData outputbydata = new OutputByData(e, window_for_output_by_date);
            await outputbydata.ProcessAsync();
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            NameChange namechange = new NameChange(window_for_user_output, textBox1);
            await namechange.ProcessAsync();
        }
    }
}
