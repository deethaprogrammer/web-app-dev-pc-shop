namespace PcShop.Seeders;

using Data;
using Models.Ports;

public static class PortsBridgeSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.PortsBridges.Any())
        {
            return;
        }

        context.PortsBridges.AddRange(
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.UsbAId, Quantity = 4 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.UsbCId, Quantity = 2 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.HdmiId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.DisplayPortId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.EthernetId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790HeroId, PortId = PortSeeder.AudioId, Quantity = 1 },

            new PortsBridge { MotherboardId = MotherboardSeeder.B650eFId, PortId = PortSeeder.UsbAId, Quantity = 6 },
            new PortsBridge { MotherboardId = MotherboardSeeder.B650eFId, PortId = PortSeeder.UsbCId, Quantity = 2 },
            new PortsBridge { MotherboardId = MotherboardSeeder.B650eFId, PortId = PortSeeder.HdmiId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.B650eFId, PortId = PortSeeder.EthernetId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.B650eFId, PortId = PortSeeder.AudioId, Quantity = 1 },

            new PortsBridge { MotherboardId = MotherboardSeeder.Z790AId, PortId = PortSeeder.UsbAId, Quantity = 4 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790AId, PortId = PortSeeder.UsbCId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790AId, PortId = PortSeeder.HdmiId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790AId, PortId = PortSeeder.DisplayPortId, Quantity = 1 },
            new PortsBridge { MotherboardId = MotherboardSeeder.Z790AId, PortId = PortSeeder.EthernetId, Quantity = 1 }
        );

        await context.SaveChangesAsync();
    }
}
