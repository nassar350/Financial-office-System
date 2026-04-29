using System;

namespace core.Domain.Entities;

public class Tasks
{
    public int Id { get; set; }

    public DateOnly AddDate { get; set; }

    public DateOnly? DoneDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsDone { get; set; }

    public int EmployeeId { get; set; }

    public int? ClientId { get; set; }

    public Employee Employee { get; set; } = null!;

    public Client? Client { get; set; } = null;
}