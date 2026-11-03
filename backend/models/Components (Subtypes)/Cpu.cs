using backend.models.Base;

namespace backend.models.Components;

[Table("CPU")] 
public class CPU : PcComponent
{
    public CPU()
    {
        ComponentType = "CPU";
    }

    public int Cores { get; set; }

    public int? PerformanceCores { get; set; }

    public int Threads { get; set; }

    [Required]
    public string Socket { get; set; } = null!;

    public int Frequency { get; set; }

    [Required]
    public int Cache { get; set; }

    public int Wattage { get; set; }

    public bool HasIntegratedGraphics { get; set; }
}