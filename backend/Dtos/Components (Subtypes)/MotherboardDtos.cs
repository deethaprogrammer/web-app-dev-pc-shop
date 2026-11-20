namespace PcShop.Dtos.Components;

using Dtos.Base;

public record MotherboardDto : PcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int PcieSlots { get; init; }
    public int RamSlots { get; init; }
    public string RamType { get; init; } = string.Empty;
    public int MaxRamCapacityGb { get; init; }
    public int SataConnections { get; init; }
    public string? OnboardWifiVersion { get; init; }
}

public record CreateMotherboardDto : CreatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int PcieSlots { get; init; }
    public int RamSlots { get; init; }
    public string RamType { get; init; } = string.Empty;
    public int MaxRamCapacityGb { get; init; }
    public int SataConnections { get; init; }
    public string? OnboardWifiVersion { get; init; }
}

public record UpdateMotherboardDto : UpdatePcComponentDto
{
    public Guid FormFactorId { get; init; }
    public string Socket { get; init; } = string.Empty;
    public int PcieSlots { get; init; }
    public int RamSlots { get; init; }
    public string RamType { get; init; } = string.Empty;
    public int MaxRamCapacityGb { get; init; }
    public int SataConnections { get; init; }
    public string? OnboardWifiVersion { get; init; }
}
