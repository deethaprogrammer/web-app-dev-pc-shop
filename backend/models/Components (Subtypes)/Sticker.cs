using backend.models.Base;

namespace backend.models.Components;

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