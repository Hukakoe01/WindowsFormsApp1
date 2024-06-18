using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.bd
{
    // создание таблицы с выводом
    public class QueryResult
    {
        /// <summary>
        /// id строки
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// запоминается отношение первоой валюты к доллору
        /// </summary>
        public float Value1 { get; set; }
        /// <summary>
        /// запоминается отношение второй валюты к дооллару
        /// </summary>
        public float Value2 { get; set; }
        /// <summary>
        /// время
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// запоминается какой id был у изначального запроса
        /// </summary>
        public int QueryId { get; set; }
        /// <summary>
        /// запрос
        /// </summary>
        public Query Query { get; set; }
        /// <summary>
        /// посчитаный перевод валюты из одной в другую
        /// </summary>
        public float Itogo { get; set; }
    }
}
