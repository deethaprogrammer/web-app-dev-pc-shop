namespace PcShop.Dtos.Ports;

public record PortsBridgeDto
{
    public Guid MotherboardId { get; init; }
    public Guid PortId { get; init; }
    public int Quantity { get; init; }
}

public record CreatePortsBridgeDto
{
    public Guid MotherboardId { get; init; }
    public Guid PortId { get; init; }
    public int Quantity { get; init; }
}

public record UpdatePortsBridgeDto
{
    public int Quantity { get; init; }
}
