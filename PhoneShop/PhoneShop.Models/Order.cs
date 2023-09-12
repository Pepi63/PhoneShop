using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneShop.Models
{
    public class Order
    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Customer Customer { get; set; } 
        public virtual Employee Employee { get; set; } 

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
