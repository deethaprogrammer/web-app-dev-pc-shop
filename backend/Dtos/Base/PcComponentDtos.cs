namespace PcShop.Dtos.Base;

public record PcComponentDto
{
    public Guid ComponentId { get; init; }
    public string ComponentType { get; init; } = string.Empty;
    public string Brand { get; init; } = string.Empty;
    public string Model { get; init; } = string.Empty;
    public decimal CurrentPrice { get; init; }
    public bool IsSellable { get; init; }
    public int StockQuantity { get; init; }
    public string ImageUrl { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int ReleaseYear { get; init; }
}

public record CreatePcComponentDto
{
    public string ComponentType { get; init; } = string.Empty;
    public string Brand { get; init; } = string.Empty;
    public string Model { get; init; } = string.Empty;
    public decimal CurrentPrice { get; init; }
    public bool IsSellable { get; init; }
    public int StockQuantity { get; init; }
    public string ImageUrl { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int ReleaseYear { get; init; }
}

public record UpdatePcComponentDto
{
    public string ComponentType { get; init; } = string.Empty;
    public string Brand { get; init; } = string.Empty;
    public string Model { get; init; } = string.Empty;
    public decimal CurrentPrice { get; init; }
    public bool IsSellable { get; init; }
    public int StockQuantity { get; init; }
    public string ImageUrl { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int ReleaseYear { get; init; }
}