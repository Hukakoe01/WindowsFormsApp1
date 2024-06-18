using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WindowsFormsApp1.bd;
//данная программа отвечает за логику изменения имени

namespace WindowsFormsApp1.workWithName
{
    internal class NameChange
    {


        private RichTextBox window_for_user_output;
        private TextBox textBox1;
        public NameChange( RichTextBox outputBox, TextBox BoxName)
        {
            window_for_user_output = outputBox;
            textBox1 = BoxName;
        }
        public async Task ProcessAsync()
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
    }
}