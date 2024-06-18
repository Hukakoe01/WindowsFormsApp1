using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.bd
{
    public class CurrencyApiResponse
    {
        public string Base { get; set; }
        public string Output { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
