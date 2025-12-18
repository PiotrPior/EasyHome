using System;
using System.Collections.Generic;
using System.Text;

namespace EasyHome.Models
{
    public class Products
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
    }
}
