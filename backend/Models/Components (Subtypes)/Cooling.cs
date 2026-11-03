namespace PcShop.Models.Components;

using Models.Base;

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
