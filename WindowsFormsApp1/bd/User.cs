using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.bd
{
    public class User
    {
        /// <summary>
        /// id пользоваеля
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// пользователь
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// постановка связи
        /// </summary>
        public List<Query> Queries { get; set; } = new List<Query>();
    }
}
