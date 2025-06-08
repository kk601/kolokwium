using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

[Table("WashingMachine")]
public class WashingMachine
{
    [Key]
    public int WashingMachineId { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double MaxWeight { get; set; }
    
    [MaxLength(100)]
    public string SerialNumber { get; set; }
}