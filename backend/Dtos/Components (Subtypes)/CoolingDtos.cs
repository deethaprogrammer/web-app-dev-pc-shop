namespace PcShop.Dtos.Components;

using Dtos.Base;

public record CoolingDto : PcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int? HeightMm { get; init; }
}

public record CreateCoolingDto : CreatePcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int? HeightMm { get; init; }
}

public record UpdateCoolingDto : UpdatePcComponentDto
{
    public string Type { get; init; } = string.Empty;
    public int? HeightMm { get; init; }
}
