using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.bd
{
    //создание таблицы с информацией из запроса
    public class Query
    {
        /// <summary>
        /// id запроса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// валюта из которой происходит перевод
        /// </summary>
        public string ValueFrom { get; set; }
        /// <summary>
        /// валюта в которую происходит перевод
        /// </summary>
        public string ValueTo { get; set; }
        /// <summary>
        /// время апроса
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// id пользователя который делает запрос
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// пользователь делающий запрос
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// количество валюты для перевода
        /// </summary>
        public float ValueToConvert { get; set; }
        /// <summary>
        /// постановка связи
        /// </summary>
        public List<QueryResult> QueryResults { get; set; } = new List<QueryResult>();
    }
}
