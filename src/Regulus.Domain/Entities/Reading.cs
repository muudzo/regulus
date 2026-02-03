using System.ComponentModel.DataAnnotations;
using Regulus.Domain.Common;

namespace Regulus.Domain.Entities;

public class Reading : BaseEntity
{
    public Guid MeterId { get; set; }
    
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    
    [Range(0, double.MaxValue, ErrorMessage = "Consumption must be a positive value")]
    public decimal ConsumptionKWh { get; set; }
    
    // Navigation property
    public Meter Meter { get; set; } = null!;
}
