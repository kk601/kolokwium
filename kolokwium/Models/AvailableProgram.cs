using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

[Table("AvailableProgram")]
public class AvailableProgram
{
    [Key]
    public int AvilableProgramId { get; set; }
    
    [ForeignKey(nameof(WashingMachine))]
    public int WashingMachineId { get; set; }
    
    [ForeignKey(nameof(Program))]
    public int ProgramId { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double Price { get; set; }
    
    public WashingMachine WashingMachine { get; set; } = null!;
    public Microsoft.VisualStudio.Web.CodeGeneration.Design.Program Program { get; set; } = null!;
    
    public ICollection<PurchaseHistory> PurchaseHistories { get; set; } = new List<PurchaseHistory>();
    
}