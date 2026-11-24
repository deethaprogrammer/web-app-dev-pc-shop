namespace PcShop.Seeders;

using Data;
using Models.Ports;

public static class PortSeeder
{
    public const int UsbAId = 1;
    public const int UsbCId = 2;
    public const int HdmiId = 3;
    public const int DisplayPortId = 4;
    public const int EthernetId = 5;
    public const int AudioId = 6;
    public const int ThunderboltId = 7;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Ports.Any())
        {
            return;
        }

        context.Ports.AddRange(
            new Port { PortId = UsbAId, Name = "USB Type-A", Type = "USB-A", Version = "3.2" },
            new Port { PortId = UsbCId, Name = "USB Type-C", Type = "USB-C", Version = "3.2" },
            new Port { PortId = HdmiId, Name = "HDMI", Type = "HDMI", Version = "2.1" },
            new Port { PortId = DisplayPortId, Name = "DisplayPort", Type = "DisplayPort", Version = "1.4" },
            new Port { PortId = EthernetId, Name = "Ethernet", Type = "Ethernet", Version = "1Gb" },
            new Port { PortId = AudioId, Name = "Audio Jack", Type = "Audio", Version = "3.5mm" },
            new Port { PortId = ThunderboltId, Name = "Thunderbolt", Type = "Thunderbolt", Version = "4" }
        );

        await context.SaveChangesAsync();
    }
}
