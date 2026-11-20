namespace PcShop.Dtos.Builds;

public record BuildDto
{
    public Guid BuildId { get; init; }
    public Guid UserId { get; init; }
    public decimal CalculatedPrice { get; init; }
    public string Name { get; init; } = string.Empty;
}

public record CreateBuildDto
{
    public Guid UserId { get; init; }
    public string Name { get; init; } = string.Empty;
}

public record UpdateBuildDto
{
    public string Name { get; init; } = string.Empty;
}
