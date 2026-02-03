using Regulus.Domain.Common;

namespace Regulus.Domain.Entities;

public class Operator : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ShortCode { get; set; } = string.Empty; // e.g., "ECONET", "NETONE"
    public string LicenseNumber { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
