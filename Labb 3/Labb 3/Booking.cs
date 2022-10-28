using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3
{
    internal class Booking : IBooking
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string TableNumber { get; set; }
        public Booking(string date, string time, string name, string tableNumber)
        {
            Name = name;
            Date = date;
            Time = time;
            TableNumber = tableNumber;
        }
    }
}