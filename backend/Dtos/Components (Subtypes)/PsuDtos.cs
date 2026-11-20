namespace PcShop.Dtos.Components;

using Dtos.Base;

public record PsuDto : PcComponentDto
{
    public int Wattage { get; init; }
    public string? Rating { get; init; }
    public int Modular { get; init; }
}

public record CreatePsuDto : CreatePcComponentDto
{
    public int Wattage { get; init; }
    public string? Rating { get; init; }
    public int Modular { get; init; }
}

public record UpdatePsuDto : UpdatePcComponentDto
{
    public int Wattage { get; init; }
    public string? Rating { get; init; }
    public int Modular { get; init; }
}
