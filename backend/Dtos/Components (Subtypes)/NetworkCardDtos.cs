namespace PcShop.Dtos.Components;

using Dtos.Base;

public record NetworkCardDto : PcComponentDto
{
    public string WifiType { get; init; } = string.Empty;
    public string? BluetoothType { get; init; }
    public int MaxSpeed { get; init; }
    public int PcieLevel { get; init; }
}

public record CreateNetworkCardDto : CreatePcComponentDto
{
    public string WifiType { get; init; } = string.Empty;
    public string? BluetoothType { get; init; }
    public int MaxSpeed { get; init; }
    public int PcieLevel { get; init; }
}

public record UpdateNetworkCardDto : UpdatePcComponentDto
{
    public string WifiType { get; init; } = string.Empty;
    public string? BluetoothType { get; init; }
    public int MaxSpeed { get; init; }
    public int PcieLevel { get; init; }
}
