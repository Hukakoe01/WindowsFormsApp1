using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WindowsFormsApp1.bd;
// данная программма отвечает за вывод информации по датам

namespace WindowsFormsApp1.ForOutput
{
    internal class OutputByData
{
    DateRangeEventArgs ee;
    private RichTextBox window_for_output_by_date;
    public OutputByData(DateRangeEventArgs e, RichTextBox outputBox)
    {
        ee = e;
        window_for_output_by_date = outputBox;
    }

    public async Task ProcessAsync()
    {
        DateTime selectedDate = ee.Start;
        using (var context = new ApplicationDbContext())
        {
            var queries = context.Queries.Include(q => q.QueryResults)
                                         .Include(q => q.User)
                                         .Where(q => q.DateTime.Date == selectedDate.Date)
                                         .ToList();
            window_for_output_by_date.Clear();
            foreach (var query in queries)
            {
                foreach (var result in query.QueryResults)
                {
                    window_for_output_by_date.AppendText($"{result.DateTime}\n" +
                                                         $"{query.User.Name}\n" +
                                                         $" {query.ValueFrom} : {result.Value1}\n" +
                                                         $" {query.ValueTo} : {result.Value2}\n\n");
                }
            }
        }
    }
}

}


