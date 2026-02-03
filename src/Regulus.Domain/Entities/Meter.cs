using System.ComponentModel.DataAnnotations;
using Regulus.Domain.Common;

namespace Regulus.Domain.Entities;

public class Meter : BaseEntity
{
    [Required]
    public string SerialNumber { get; set; } = string.Empty;
    
    public DateTime InstallationDate { get; set; }
    
    public Guid SubscriberId { get; set; }
    
    public MeterStatus Status { get; set; } = MeterStatus.Active;
    
    // Navigation properties
    public Subscriber Subscriber { get; set; } = null!;
    public ICollection<Reading> Readings { get; set; } = new List<Reading>();
}

public enum MeterStatus
{
    Active,
    Inactive,
    Maintenance
}
