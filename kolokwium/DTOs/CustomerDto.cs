namespace kolokwium.DTOs;

public class CustomerDto
{
    public int CustomerId { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public List<PurchaseLineItemDto> Purchases { get; set; } = null!;
}

public class WashingMachineInfoDto
{
    public string SerialNumber { get; set; } = null!;
    public Double MaxWeight { get; set; }
}

public class ProgramInfoDto
{
    public string Name { get; set; } = null!;
    public int Duration { get; set; }
}

public class PurchaseLineItemDto
{
    public DateTime date { get; set; }
    public int Rating { get; set; }
    public Double Price { get; set; }
    public WashingMachineInfoDto WashingMachine { get; set; } = null!;
    public ProgramInfoDto Program { get; set; } = null!;
}