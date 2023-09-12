using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Data;
using PhoneShop.Models;

public class EmployeeService
{
    private readonly AppDbContext context;

    public EmployeeService(AppDbContext context)
    {
        this.context = context;
    }

    public List<Employee> GetAllEmployees()
    {
        return context.Employees.ToList();
    }

    public Employee GetEmployeeById(int id)
    {
        return context.Employees.FirstOrDefault(e => e.EmployeeID == id);
    }

    public void AddEmployee(Employee employee)
    {
        context.Employees.Add(employee);
        context.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        context.Entry(employee).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void DeleteEmployee(int id)
    {
        var employee = context.Employees.Find(id);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
    }
}
