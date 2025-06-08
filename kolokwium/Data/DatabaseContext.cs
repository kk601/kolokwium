using kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Data;

public class DatabaseContext : DbContext
{
    public DbSet<AvailableProgram> AvailablePrograms { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<kolokwium.Models.Program> Programs { get; set; }
    public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
    public DbSet<WashingMachine> WashingMachines { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe" },
            new Customer() { CustomerId = 2, FirstName = "Jane", LastName = "Doe" },
            new Customer() { CustomerId = 3, FirstName = "Julie", LastName = "Doe" },
        });
        
        modelBuilder.Entity<PurchaseHistory>().HasData(new List<PurchaseHistory>()
        {
            new PurchaseHistory() { AvailableProgramId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2025-05-01"), Rating = 2},
        });
        
        modelBuilder.Entity<AvailableProgram>().HasData(new List<AvailableProgram>()
        {
            new AvailableProgram() { AvilableProgramId = 1, WashingMachineId = 1, ProgramId = 1, Price = 9.99},
        });
        
        modelBuilder.Entity<kolokwium.Models.Program>().HasData(new List<kolokwium.Models.Program>()
        {
            new kolokwium.Models.Program() { ProgramId = 1, Name = "test", DurationMinutes = 10, TemperatureCelsius = 99 }
        });
        
        modelBuilder.Entity<WashingMachine>().HasData(new List<WashingMachine>()
        {
            new WashingMachine() { WashingMachineId = 1, MaxWeight = 99.9, SerialNumber = "123"},
        });
        
    }
}