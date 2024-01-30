using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_01_2024.Exceptions
{
    internal class ProductAlreadyExistsException:Exception
    {
        public ProductAlreadyExistsException():base("Product Siyahida Movcuddur!")
        {

        }
        public ProductAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
