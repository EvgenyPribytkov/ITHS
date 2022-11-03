using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    internal class Product : IProduct
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public Product(string productName, string price, string quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
