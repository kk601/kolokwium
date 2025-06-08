using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

[Table("Program")]
[PrimaryKey(nameof(ProgramId))]
public class Program
{
    [Key]
    public int ProgramId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    public int DurationMinutes { get; set; }
    public int TemperatureCelsius { get; set; }
}