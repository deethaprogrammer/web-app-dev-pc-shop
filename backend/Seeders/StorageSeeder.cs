namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class StorageSeeder
{
    public const int Samsung990Pro1TbId = 15;
    public const int Sn850x2TbId = 16;
    public const int Barracuda4TbId = 17;
    public const int Samsung870Evo1TbId = 18;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Storages.Any())
        {
            return;
        }

        context.Storages.AddRange(
            new Storage
            {
                ComponentId = Samsung990Pro1TbId,
                Name = "Samsung 990 PRO 1TB NVMe SSD",
                Brand = "Samsung",
                Model = "990 PRO 1TB NVMe SSD",
                CurrentPrice = 129.99m,
                IsSellable = true,
                StockQuantity = 40,
                ImageUrl = "https://example.com/images/990pro-1tb.jpg",
                Description = "High-performance PCIe 4.0 NVMe SSD.",
                ReleaseYear = 2022,
                FormFactorId = FormFactorSeeder.M2_2280Id,
                StorageSize = 1000,
                Speed = 7450,
                Type = StorageType.Nvme,
                HasHeatsink = false,
                Wattage = 7
            },
            new Storage
            {
                ComponentId = Sn850x2TbId,
                Name = "WD_BLACK SN850X 2TB NVMe SSD",
                Brand = "Western Digital",
                Model = "WD_BLACK SN850X 2TB NVMe SSD",
                CurrentPrice = 229.99m,
                IsSellable = true,
                StockQuantity = 22,
                ImageUrl = "https://example.com/images/sn850x-2tb.jpg",
                Description = "Gaming-focused NVMe SSD with heatsink option.",
                ReleaseYear = 2022,
                FormFactorId = FormFactorSeeder.M2_2280Id,
                StorageSize = 2000,
                Speed = 7300,
                Type = StorageType.Nvme,
                HasHeatsink = true,
                Wattage = 8
            },
            new Storage
            {
                ComponentId = Barracuda4TbId,
                Name = "Seagate Barracuda 4TB HDD",
                Brand = "Seagate",
                Model = "Barracuda 4TB HDD",
                CurrentPrice = 89.99m,
                IsSellable = true,
                StockQuantity = 35,
                ImageUrl = "https://example.com/images/barracuda-4tb.jpg",
                Description = "Reliable mass storage hard drive.",
                ReleaseYear = 2020,
                FormFactorId = FormFactorSeeder.Ssd35Id,
                StorageSize = 4000,
                Speed = 190,
                Type = StorageType.Hdd,
                HasHeatsink = false,
                Wattage = 8
            },
            new Storage
            {
                ComponentId = Samsung870Evo1TbId,
                Name = "Samsung 870 EVO 1TB SATA SSD",
                Brand = "Samsung",
                Model = "870 EVO 1TB SATA SSD",
                CurrentPrice = 89.99m,
                IsSellable = true,
                StockQuantity = 28,
                ImageUrl = "https://example.com/images/870evo-1tb.jpg",
                Description = "Reliable 2.5-inch SATA SSD.",
                ReleaseYear = 2021,
                FormFactorId = FormFactorSeeder.Ssd25Id,
                StorageSize = 1000,
                Speed = 560,
                Type = StorageType.Ssd,
                HasHeatsink = false,
                Wattage = 4
            }
        );

        await context.SaveChangesAsync();
    }
}
