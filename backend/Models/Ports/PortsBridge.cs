namespace PcShop.Models.Ports;

using Models.Components;

[Table("PortsBridge")]
[PrimaryKey(nameof(MotherboardId), nameof(PortId))]
public class PortsBridge
{
    public int MotherboardId { get; set; }
    public Motherboard Motherboard { get; set; } = null!;

    public int PortId { get; set; }
    public Port Port { get; set; } = null!;

    public int Quantity { get; set; }
}
