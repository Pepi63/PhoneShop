using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Data;
using PhoneShop.Models;

public class CustomerService
{
    private readonly AppDbContext context;

    public CustomerService(AppDbContext context)
    {
        this.context = context;
    }

    public List<Customer> GetAllCustomers()
    {
        return context.Customers.ToList();
    }

    public Customer GetCustomerById(int id)
    {
        return context.Customers.FirstOrDefault(c => c.CustomerID == id);
    }

    public void AddCustomer(Customer customer)
    {
        context.Customers.Add(customer);
        context.SaveChanges();
    }

    public void UpdateCustomer(Customer customer)
    {
        context.Entry(customer).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void DeleteCustomer(int id)
    {
        var customer = context.Customers.Find(id);
        if (customer != null)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
