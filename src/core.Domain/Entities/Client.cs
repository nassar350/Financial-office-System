using System.Collections.Generic;

namespace core.Domain.Entities;

public class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Ssn { get; set; } = string.Empty;

    public string FileNumber { get; set; } = string.Empty;

    public string TaxesNumber { get; set; } = string.Empty;

    public string ClientType { get; set; } = string.Empty;

    public string ActivityType { get; set; } = string.Empty;

    public string ActivityAddress { get; set; } = string.Empty;

    public string ClientAddress { get; set; } = string.Empty;

    public bool IsVip { get; set; }

    public bool HasAddedValue { get; set; }

    public ICollection<ClientPhone> Phones { get; set; } = new HashSet<ClientPhone>();

    public ICollection<Financial> Financials { get; set; } = new HashSet<Financial>();

    public ICollection<EmployeeTask> Tasks { get; set; } = new HashSet<EmployeeTask>();
}