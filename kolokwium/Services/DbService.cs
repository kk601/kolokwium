using System.Data;
using kolokwium.Data;
using kolokwium.DTOs;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<CustomerDto> GetCustomerById(int customerId)
    {
        var purchase = await _context.Customers
            .Select(e => new CustomerDto
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                PhoneNumber = e.PhoneNumber,
                Purchases = e.PurchaseHistories.Select(e => new PurchaseLineItemDto()
                {
                    date = e.PurchaseDate,
                    Rating = e.Rating,
                    Price = e.AvailableProgram.Price,
                    WashingMachine = new WashingMachineInfoDto()
                    {
                        SerialNumber = e.AvailableProgram.WashingMachine.SerialNumber,
                        MaxWeight = e.AvailableProgram.WashingMachine.MaxWeight
                    },
                    // Program = new ProgramInfoDto()
                    // {
                    //    Name = e.AvailableProgram.Program.Name,
                    //    Duration = e.AvailableProgram.Program.DurationMinutes
                    //}
                        
                    
                }).ToList()
            })
            .FirstOrDefaultAsync(e => e.CustomerId == customerId);

        if (purchase is null)
            throw new Exception();
        
        return purchase;
    }
}