namespace PcShop.Models.Components;

using Models.Base;

[Table("RAM")]
public class RAM : PcComponent
{
    public RAM()
    {
        ComponentType = "RAM";
    }

    [Required]
    public string Type { get; set; } = null!;

    public int Frequency { get; set; }

    public int Size { get; set; }

    public string? Color { get; set; }

    public int Wattage { get; set; }
}
