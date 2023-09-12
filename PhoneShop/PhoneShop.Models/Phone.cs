using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneShop.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
