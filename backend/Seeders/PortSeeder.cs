namespace PcShop.Seeders;

using Data;
using Models.Ports;

public static class PortSeeder
{
    public static readonly Guid UsbAId = Guid.Parse("30000000-0000-0000-0000-000000000001");
    public static readonly Guid UsbCId = Guid.Parse("30000000-0000-0000-0000-000000000002");
    public static readonly Guid HdmiId = Guid.Parse("30000000-0000-0000-0000-000000000003");
    public static readonly Guid DisplayPortId = Guid.Parse("30000000-0000-0000-0000-000000000004");
    public static readonly Guid EthernetId = Guid.Parse("30000000-0000-0000-0000-000000000005");
    public static readonly Guid AudioId = Guid.Parse("30000000-0000-0000-0000-000000000006");
    public static readonly Guid ThunderboltId = Guid.Parse("30000000-0000-0000-0000-000000000007");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Ports.Any())
        {
            return;
        }

        context.Ports.AddRange(
            new Port { Id = UsbAId, Name = "USB Type-A", Type = "USB-A", Version = "3.2" },
            new Port { Id = UsbCId, Name = "USB Type-C", Type = "USB-C", Version = "3.2" },
            new Port { Id = HdmiId, Name = "HDMI", Type = "HDMI", Version = "2.1" },
            new Port { Id = DisplayPortId, Name = "DisplayPort", Type = "DisplayPort", Version = "1.4" },
            new Port { Id = EthernetId, Name = "Ethernet", Type = "Ethernet", Version = "1Gb" },
            new Port { Id = AudioId, Name = "Audio Jack", Type = "Audio", Version = "3.5mm" },
            new Port { Id = ThunderboltId, Name = "Thunderbolt", Type = "Thunderbolt", Version = "4" }
        );

        await context.SaveChangesAsync();
    }
}
