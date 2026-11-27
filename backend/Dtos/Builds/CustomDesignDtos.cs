namespace PcShop.Dtos.Builds;

public record CustomDesignDto
{
    public Guid CustomDesignId { get; init; }
    public Guid CaseComponentId { get; init; }
    public Guid StickerId { get; init; }
    public Guid BuildId { get; init; }
    public string SideLocation { get; init; } = string.Empty;
    public int XAxis { get; init; }
    public int YAxis { get; init; }
    public int RotationDegree { get; init; }
}

public record CreateCustomDesignDto
{
    public Guid CaseComponentId { get; init; }
    public Guid StickerId { get; init; }
    public Guid BuildId { get; init; }
    public string SideLocation { get; init; } = string.Empty;
    public int XAxis { get; init; }
    public int YAxis { get; init; }
    public int RotationDegree { get; init; }
}

public record UpdateCustomDesignDto
{
    public Guid CaseComponentId { get; init; }
    public Guid StickerId { get; init; }
    public string SideLocation { get; init; } = string.Empty;
    public int XAxis { get; init; }
    public int YAxis { get; init; }
    public int RotationDegree { get; init; }
}
