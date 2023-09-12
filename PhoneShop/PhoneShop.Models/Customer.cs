﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneShop.Models
{
    public class Customer
    {
        public virtual List<Order> Orders { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
