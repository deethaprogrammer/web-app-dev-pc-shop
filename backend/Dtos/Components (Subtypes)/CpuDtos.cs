namespace PcShop.Dtos.Components;

using Dtos.Base;

public record CpuDto : PcComponentDto
{
    public int Cores { get; init; }
    public int? PerformanceCores { get; init; }
    public int Threads { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Cache { get; init; }
    public int Wattage { get; init; }
    public bool HasIntegratedGraphics { get; init; }
}

public record CreateCpuDto : CreatePcComponentDto
{
    public int Cores { get; init; }
    public int? PerformanceCores { get; init; }
    public int Threads { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Cache { get; init; }
    public int Wattage { get; init; }
    public bool HasIntegratedGraphics { get; init; }
}

public record UpdateCpuDto : UpdatePcComponentDto
{
    public int Cores { get; init; }
    public int? PerformanceCores { get; init; }
    public int Threads { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Cache { get; init; }
    public int Wattage { get; init; }
    public bool HasIntegratedGraphics { get; init; }
}
