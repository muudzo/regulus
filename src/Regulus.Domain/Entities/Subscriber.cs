using System.ComponentModel.DataAnnotations;
using Regulus.Domain.Common;

namespace Regulus.Domain.Entities;

public class Subscriber : BaseEntity
{
    [Required]
    public string Name { get; set; } = string.Empty;
    
    public string Address { get; set; } = string.Empty;
    
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;
    
    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    
    // Navigation properties
    public ICollection<Meter> Meters { get; set; } = new List<Meter>();
    public ICollection<Reading> Readings { get; set; } = new List<Reading>();
}
