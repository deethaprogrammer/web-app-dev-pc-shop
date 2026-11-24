namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class MotherboardSeeder
{
    public const int Z790HeroId = 9;
    public const int B650eFId = 10;
    public const int Z790AId = 11;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Motherboards.Any())
        {
            return;
        }

        context.Motherboards.AddRange(
            new Motherboard
            {
                ComponentId = Z790HeroId,
                Name = "ASUS ROG Maximus Z790 Hero",
                Brand = "ASUS",
                Model = "ROG Maximus Z790 Hero",
                CurrentPrice = 629.99m,
                IsSellable = true,
                StockQuantity = 6,
                ImageUrl = "https://example.com/images/z790-hero.jpg",
                Description = "Premium Intel Z790 motherboard with robust power delivery.",
                ReleaseYear = 2022,
                FormFactorId = FormFactorSeeder.AtxId,
                Socket = "LGA1700",
                PcieSlots = 3,
                RamSlots = 4,
                RamType = "DDR5",
                MaxRamCapacityGb = 128,
                SataConnections = 6,
                OnboardWifiVersion = "Wi-Fi 6E"
            },
            new Motherboard
            {
                ComponentId = B650eFId,
                Name = "Gigabyte B650E AORUS Master",
                Brand = "Gigabyte",
                Model = "B650E AORUS Master",
                CurrentPrice = 349.99m,
                IsSellable = true,
                StockQuantity = 10,
                ImageUrl = "https://example.com/images/b650e-master.jpg",
                Description = "High-end AMD B650E motherboard with PCIe 5.0 support.",
                ReleaseYear = 2022,
                FormFactorId = FormFactorSeeder.AtxId,
                Socket = "AM5",
                PcieSlots = 3,
                RamSlots = 4,
                RamType = "DDR5",
                MaxRamCapacityGb = 128,
                SataConnections = 4,
                OnboardWifiVersion = "Wi-Fi 6E"
            },
            new Motherboard
            {
                ComponentId = Z790AId,
                Name = "MSI PRO Z790-A WiFi",
                Brand = "MSI",
                Model = "PRO Z790-A WiFi",
                CurrentPrice = 229.99m,
                IsSellable = true,
                StockQuantity = 18,
                ImageUrl = "https://example.com/images/z790-a.jpg",
                Description = "Well-rounded Intel Z motherboard for mainstream builds.",
                ReleaseYear = 2022,
                FormFactorId = FormFactorSeeder.AtxId,
                Socket = "LGA1700",
                PcieSlots = 3,
                RamSlots = 4,
                RamType = "DDR5",
                MaxRamCapacityGb = 128,
                SataConnections = 6,
                OnboardWifiVersion = "Wi-Fi 6E"
            }
        );

        await context.SaveChangesAsync();
    }
}
