using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneShop.Models
{
    public class OrderDetail
    {
        public virtual Phone Phone { get; set; }
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int PhoneID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
