using PhoneShop.Data;
using PhoneShop.Models;
using System;
using System.Collections.Generic;

namespace PhoneShop.Seeder
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void SeedPhones(AppDbContext context)
        {
            var phones = new List<Phone>
        {
            new Phone { Model = "iPhone 13", Manufacturer = "Apple", Price = 999.99m, StockQuantity = 10 },
            new Phone { Model = "Galaxy S21", Manufacturer = "Samsung", Price = 899.99m, StockQuantity = 15 },
            new Phone { Model = "Pixel 6", Manufacturer = "Google", Price = 799.99m, StockQuantity = 8 },
            new Phone { Model = "OnePlus 9", Manufacturer = "OnePlus", Price = 899.99m, StockQuantity = 12 },
            new Phone { Model = "Xperia 1 III", Manufacturer = "Sony", Price = 1099.99m, StockQuantity = 5 },
            new Phone { Model = "Mi 11", Manufacturer = "Xiaomi", Price = 799.99m, StockQuantity = 10 },
            new Phone { Model = "ROG Phone 5", Manufacturer = "ASUS", Price = 1299.99m, StockQuantity = 7 },
            new Phone { Model = "Mate 40 Pro", Manufacturer = "Huawei", Price = 899.99m, StockQuantity = 9 },
            new Phone { Model = "LG G8", Manufacturer = "LG", Price = 499.99m, StockQuantity = 3 },
            new Phone { Model = "Moto G Power", Manufacturer = "Motorola", Price = 249.99m, StockQuantity = 20 },
        };

            context.Phones.AddRange(phones);
            context.SaveChanges();
        }
        public static void SeedCustomers(AppDbContext context)
        {
            var customers = new List<Customer>
        {
            new Customer { Name = "John Doe", Email = "john@example.com", PhoneNumber = "123-456-7890", Address = "123 Main St" },
            new Customer { Name = "Jane Smith", Email = "jane@example.com", PhoneNumber = "987-654-3210", Address = "456 Elm St" },
            new Customer { Name = "Alice Johnson", Email = "alice@example.com", PhoneNumber = "555-555-5555", Address = "789 Oak St" },
            new Customer { Name = "Bob Wilson", Email = "bob@example.com", PhoneNumber = "777-777-7777", Address = "101 Pine St" },
            new Customer { Name = "Emily Davis", Email = "emily@example.com", PhoneNumber = "444-444-4444", Address = "246 Maple St" },
            new Customer { Name = "David Brown", Email = "david@example.com", PhoneNumber = "222-222-2222", Address = "888 Cedar St" },
            new Customer { Name = "Sophia Lee", Email = "sophia@example.com", PhoneNumber = "111-111-1111", Address = "333 Birch St" },
            new Customer { Name = "Oliver Kim", Email = "oliver@example.com", PhoneNumber = "999-999-9999", Address = "555 Redwood St" },
            new Customer { Name = "Ava Smith", Email = "ava@example.com", PhoneNumber = "666-666-6666", Address = "777 Elmwood St" },
            new Customer { Name = "Liam Wilson", Email = "liam@example.com", PhoneNumber = "333-333-3333", Address = "444 Oakwood St" },
        };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
        public static void SeedEmployees(AppDbContext context)
        {
            var employees = new List<Employee>
        {
            new Employee { FirstName = "Alice", LastName = "Johnson", Position = "Sales Associate", Salary = 45000 },
            new Employee { FirstName = "Bob", LastName = "Smith", Position = "Manager", Salary = 65000 },
            new Employee { FirstName = "Charlie", LastName = "Brown", Position = "Sales Associate", Salary = 42000 },
            new Employee { FirstName = "David", LastName = "Wilson", Position = "Manager", Salary = 68000 },
            new Employee { FirstName = "Ella", LastName = "Miller", Position = "Sales Associate", Salary = 46000 },
            new Employee { FirstName = "Frank", LastName = "Davis", Position = "Manager", Salary = 70000 },
            new Employee { FirstName = "Grace", LastName = "Lee", Position = "Sales Associate", Salary = 43000 },
            new Employee { FirstName = "Henry", LastName = "Anderson", Position = "Manager", Salary = 67000 },
            new Employee { FirstName = "Isabella", LastName = "Martin", Position = "Sales Associate", Salary = 47000 },
            new Employee { FirstName = "Jacob", LastName = "Thompson", Position = "Manager", Salary = 72000 },
        };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
        public static void SeedOrders(AppDbContext context)
        {
            var orders = new List<Order>
        {
            new Order { CustomerID = 1, EmployeeID = 2, OrderDate = DateTime.Now, TotalAmount = 1999.98m },
            new Order { CustomerID = 2, EmployeeID = 1, OrderDate = DateTime.Now, TotalAmount = 1499.99m },
            new Order { CustomerID = 3, EmployeeID = 3, OrderDate = DateTime.Now, TotalAmount = 799.99m },
            new Order { CustomerID = 4, EmployeeID = 2, OrderDate = DateTime.Now, TotalAmount = 899.99m },
            new Order { CustomerID = 5, EmployeeID = 4, OrderDate = DateTime.Now, TotalAmount = 1199.99m },
            new Order { CustomerID = 6, EmployeeID = 5, OrderDate = DateTime.Now, TotalAmount = 699.99m },
            new Order { CustomerID = 7, EmployeeID = 1, OrderDate = DateTime.Now, TotalAmount = 999.99m },
            new Order { CustomerID = 8, EmployeeID = 3, OrderDate = DateTime.Now, TotalAmount = 1499.99m },
            new Order { CustomerID = 9, EmployeeID = 4, OrderDate = DateTime.Now, TotalAmount = 399.99m },
            new Order { CustomerID = 10, EmployeeID = 2, OrderDate = DateTime.Now, TotalAmount = 799.99m },
        };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }

}

