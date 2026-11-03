using backend.models.Components;

namespace backend.models.Ports;
[Table("PortsBridge")]
[PrimaryKey(nameof(MotherboardId), nameof(PortId))]
public class PortsBridge
{
    public Guid MotherboardId { get; set; }
    public Motherboard Motherboard { get; set; } = null!;

    public Guid PortId { get; set; }
    public Port Port { get; set; } = null!;

    public int Quantity { get; set; }
}