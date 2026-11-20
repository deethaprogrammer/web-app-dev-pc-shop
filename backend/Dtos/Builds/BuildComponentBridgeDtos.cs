namespace PcShop.Dtos.Builds;

public record BuildComponentBridgeDto
{
    public Guid BuildId { get; init; }
    public Guid ComponentId { get; init; }
    public int Quantity { get; init; }
}

public record CreateBuildComponentBridgeDto
{
    public Guid BuildId { get; init; }
    public Guid ComponentId { get; init; }
    public int Quantity { get; init; }
}

public record UpdateBuildComponentBridgeDto
{
    public int Quantity { get; init; }
}
