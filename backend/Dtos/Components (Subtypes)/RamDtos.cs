namespace PcShop.Dtos.Components;

using Dtos.Base;

public record RamDto : PcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Size { get; init; }
    public string? Color { get; init; }
    public int Wattage { get; init; }
}

public record CreateRamDto : CreatePcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Size { get; init; }
    public string? Color { get; init; }
    public int Wattage { get; init; }
}

public record UpdateRamDto : UpdatePcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Size { get; init; }
    public string? Color { get; init; }
    public int Wattage { get; init; }
}
