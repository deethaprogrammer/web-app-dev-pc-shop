namespace PcShop.Models.Components;

using Models.Base;

[Table("NetworkCard")]
public class NetworkCard : PcComponent
{
    public NetworkCard()
    {
        ComponentType = "NetworkCard";
    }

    [Required]
    public string WifiType { get; set; } = null!;

    public string? BluetoothType { get; set; }

    public int MaxSpeed { get; set; }

    public int PcieLevel { get; set; }
}
