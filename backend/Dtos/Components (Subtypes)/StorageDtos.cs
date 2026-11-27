namespace PcShop.Dtos.Components;

using Dtos.Base;

public record StorageDto : PcComponentDto
{
    public Guid FormFactorId { get; init; }
    public int StorageSize { get; init; }
    public int Speed { get; init; }
    public int Type { get; init; }
    public int? Heatsink { get; init; }
    public int Wattage { get; init; }
}

public record CreateStorageDto : CreatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public int StorageSize { get; init; }
    public int Speed { get; init; }
    public int Type { get; init; }
    public int? Heatsink { get; init; }
    public int Wattage { get; init; }
}

public record UpdateStorageDto : UpdatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public int StorageSize { get; init; }
    public int Speed { get; init; }
    public int Type { get; init; }
    public int? Heatsink { get; init; }
    public int Wattage { get; init; }
}
