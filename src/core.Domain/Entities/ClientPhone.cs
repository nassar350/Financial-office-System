namespace core.Domain.Entities;

public class ClientPhone
{
    public int Id { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public int ClientId { get; set; }

    public Client Client { get; set; } = null!;
}