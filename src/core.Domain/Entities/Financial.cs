using System;

namespace core.Domain.Entities;

public class Financial
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public decimal Value { get; set; }

    public string Type { get; set; } = string.Empty;

    public string FeeType { get; set; } = string.Empty;

    public int EmployeeId { get; set; }

    public int ClientId { get; set; }

    public Employee Employee { get; set; } = null!;

    public Client Client { get; set; } = null!;
}