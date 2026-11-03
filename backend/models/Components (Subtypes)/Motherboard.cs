using backend.models.Base;
using backend.models.FormFactor;

namespace backend.models.Components;

[Table("Motherboard")] 
public class Motherboard : PcComponent
{
    public Motherboard()
    {
        ComponentType = "Motherboard";
    }
    public Guid FormFactorId { get; set; } 

    public BoardFormFactor FormFactor { get; set; } = null!;

    [Required]
    public string Socket { get; set; } = null!;

    public int PcieSlots { get; set; }

    public int RamSlots { get; set; }

    [Required]
    public string RamType { get; set; } = null!;

    public int MaxRamCapacityGb { get; set; }

    public int SataConnections { get; set; }

    public string? OnboardWifiVersion { get; set; }

}