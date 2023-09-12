using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Data;
using PhoneShop.Models;

public class PhoneService
{
    private readonly AppDbContext context;

    public PhoneService(AppDbContext context)
    {
        this.context = context;
    }

    public List<Phone> GetAllPhones()
    {
        return context.Phones.ToList();
    }

    public Phone GetPhoneById(int id)
    {
        return context.Phones.FirstOrDefault(p => p.PhoneID == id);
    }

    public void AddPhone(Phone phone)
    {
        context.Phones.Add(phone);
        context.SaveChanges();
    }

    public void UpdatePhone(Phone phone)
    {
        context.Entry(phone).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void DeletePhone(int id)
    {
        var phone = context.Phones.Find(id);
        if (phone != null)
        {
            context.Phones.Remove(phone);
            context.SaveChanges();
        }
    }
}
