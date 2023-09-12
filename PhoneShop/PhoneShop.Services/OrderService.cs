using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Data;
using PhoneShop.Models;

public class OrderService
{
    private readonly AppDbContext context;

    public OrderService(AppDbContext context)
    {
        this.context = context;
    }

    public List<Order> GetAllOrders()
    {
        return context.Orders.ToList();
    }

    public Order GetOrderById(int id)
    {
        return context.Orders.FirstOrDefault(o => o.OrderID == id);
    }

    public void AddOrder(Order order)
    {
        context.Orders.Add(order);
        context.SaveChanges();
    }

    public void UpdateOrder(Order order)
    {
        context.Entry(order).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void DeleteOrder(int id)
    {
        var order = context.Orders.Find(id);
        if (order != null)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
