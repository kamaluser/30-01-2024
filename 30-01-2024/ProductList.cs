using _30_01_2024.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_01_2024
{
    internal class ProductList
    {
        private Product[] _products = new Product[0];
        public ProductList()
        {
            
        }

        public ProductList(Product[] products)
        {
            _products = products;   
        }
        public Product this[int i]
        {
            get => _products[i];
            set
            {
                if (!HasSameProduct(value.No))
                {
                    _products[i] = value;
                }
                else
                {
                    throw new ProductAlreadyExistsException;
                }
            }
        }
        
        public bool HasSameProduct(int no)
        {
            foreach(var item in _products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
