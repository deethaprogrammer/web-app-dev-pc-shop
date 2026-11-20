namespace PcShop.Dtos.Components;

using Dtos.Base;

public record GpuDto : PcComponentDto
{
    public double VulkanVersion { get; init; }
    public double? OpenglVersion { get; init; }
    public int? CudaCores { get; init; }
    public int Cores { get; init; }
    public int VramAmount { get; init; }
    public string VramType { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Wattage { get; init; }
    public string Cooling { get; init; } = string.Empty;
    public int? FansAmount { get; init; }
    public bool Overclockable { get; init; }
    public bool BiosLock { get; init; }
    public string? Color { get; init; }
    public int LengthMm { get; init; }
}

public record CreateGpuDto : CreatePcComponentDto
{
    public double VulkanVersion { get; init; }
    public double? OpenglVersion { get; init; }
    public int? CudaCores { get; init; }
    public int Cores { get; init; }
    public int VramAmount { get; init; }
    public string VramType { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Wattage { get; init; }
    public string Cooling { get; init; } = string.Empty;
    public int? FansAmount { get; init; }
    public bool Overclockable { get; init; }
    public bool BiosLock { get; init; }
    public string? Color { get; init; }
    public int LengthMm { get; init; }
}

public record UpdateGpuDto : UpdatePcComponentDto
{
    public double VulkanVersion { get; init; }
    public double? OpenglVersion { get; init; }
    public int? CudaCores { get; init; }
    public int Cores { get; init; }
    public int VramAmount { get; init; }
    public string VramType { get; init; } = string.Empty;
    public int Frequency { get; init; }
    public int Wattage { get; init; }
    public string Cooling { get; init; } = string.Empty;
    public int? FansAmount { get; init; }
    public bool Overclockable { get; init; }
    public bool BiosLock { get; init; }
    public string? Color { get; init; }
    public int LengthMm { get; init; }
}
