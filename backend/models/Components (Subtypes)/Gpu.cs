using backend.models.Base;

namespace backend.models.Components;

[Table("GPU")] 
public class GPU : PcComponent
{
    public GPU()
    {
        ComponentType = "GPU";
    }

    [Required, Precision(10, 1)]
    public double VulkanVersion { get; set; }

    [Precision(10, 1)]
    public double? OpenglVersion { get; set; }

    public int? CudaCores { get; set; }

    public int Cores { get; set; }

    public int VramAmount { get; set; }

    [Required]
    public string VramType { get; set; } = null!;

    public int Frequency { get; set; }

    public int Wattage { get; set; }

    [Required]
    public string Cooling { get; set; } = null!;

    public int? FansAmount { get; set; }

    public bool Overclockable { get; set; }

    public bool BiosLock { get; set; }

    public string? Color { get; set; }

    public int LengthMm { get; set; }
}