using System.Collections.Generic;

namespace core.Domain.Entities;

public class Employee
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public decimal Salary { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<EmployeePhone> Phones { get; set; } = new HashSet<EmployeePhone>();

    public ICollection<Financial> Financials { get; set; } = new HashSet<Financial>();

    public ICollection<EmployeeTask> Tasks { get; set; } = new HashSet<EmployeeTask>();

    public ICollection<EmployeeRole> EmployeeRoles { get; set; } = new HashSet<EmployeeRole>();
}