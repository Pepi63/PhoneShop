using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneShop.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
