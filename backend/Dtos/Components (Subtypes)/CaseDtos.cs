namespace PcShop.Dtos.Components;

using Dtos.Base;

public record CaseDto : PcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Color { get; init; } = string.Empty;
    public string PanelType { get; init; } = string.Empty;
    public string? CableManagement { get; init; }
    public int MaxGpuClearanceMm { get; init; }
    public int MaxCpuCoolerHeightMm { get; init; }
}

public record CreateCaseDto : CreatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Color { get; init; } = string.Empty;
    public string PanelType { get; init; } = string.Empty;
    public string? CableManagement { get; init; }
    public int MaxGpuClearanceMm { get; init; }
    public int MaxCpuCoolerHeightMm { get; init; }
}

public record UpdateCaseDto : UpdatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Color { get; init; } = string.Empty;
    public string PanelType { get; init; } = string.Empty;
    public string? CableManagement { get; init; }
    public int MaxGpuClearanceMm { get; init; }
    public int MaxCpuCoolerHeightMm { get; init; }
}
