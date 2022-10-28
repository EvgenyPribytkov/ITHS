using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    internal interface IProduct
    {
        string ProductName { get; set; }
        string Price { get; set; }
        string Quantity { get; set; }
    }
}
