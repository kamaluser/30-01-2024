using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_01_2024
{
    internal class Product
    {
        private static int _no = 0;
        public int No { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }

        public Product(string name, decimal price, ProductType type)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
