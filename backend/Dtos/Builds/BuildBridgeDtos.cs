namespace PcShop.Dtos.Builds;

public record BuildBridgeDto
{
    public Guid BuildId { get; init; }
    public Guid OrderId { get; init; }
}

public record CreateBuildBridgeDto
{
    public Guid BuildId { get; init; }
    public Guid OrderId { get; init; }
}
