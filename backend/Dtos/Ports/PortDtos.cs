namespace PcShop.Dtos.Ports;

public record PortDto
{
    public Guid PortId { get; init; }
    public string Type { get; init; } = string.Empty;
    public string? Version { get; init; }
}

public record CreatePortDto
{
    public string Type { get; init; } = string.Empty;
    public string? Version { get; init; }
}

public record UpdatePortDto
{
    public string Type { get; init; } = string.Empty;
    public string? Version { get; init; }
}
