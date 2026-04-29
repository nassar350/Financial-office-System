namespace core.Domain.Entities;

public class EmployeePhone
{
    public int Id { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = null!;
}