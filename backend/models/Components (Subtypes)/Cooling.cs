using backend.models.Base;

namespace backend.models.Components;

[Table("Cooling")] 
public class Cooling : PcComponent
{
    public Cooling()
    {
        ComponentType = "Cooling";
    }

    [Required]
    public string Type { get; set; } = null!;

    public int? HeightMm { get; set; }
}