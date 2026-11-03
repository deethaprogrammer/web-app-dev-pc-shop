namespace PcShop.Models.Components;

using Models.Base;

[Table("Sticker")]
public class Sticker : PcComponent
{
    public Sticker()
    {
        ComponentType = "Sticker";
    }

    public int WidthMm { get; set; }

    public int HeightMm { get; set; }
}
