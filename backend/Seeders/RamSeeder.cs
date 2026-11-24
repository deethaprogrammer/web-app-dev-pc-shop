namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class RamSeeder
{
    public const int Ddr5_32GbId = 12;
    public const int Ddr5_64GbId = 13;
    public const int Ddr4_32GbId = 14;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.RAMs.Any())
        {
            return;
        }

        context.RAMs.AddRange(
            new RAM
            {
                ComponentId = Ddr5_32GbId,
                Name = "Corsair Vengeance DDR5 32GB 6000MHz",
                Brand = "Corsair",
                Model = "Vengeance DDR5 32GB (2x16GB) 6000MHz",
                CurrentPrice = 99.99m,
                IsSellable = true,
                StockQuantity = 30,
                ImageUrl = "https://example.com/images/vengeance-ddr5.jpg",
                Description = "Fast DDR5 memory kit for gaming builds.",
                ReleaseYear = 2022,
                Type = "DDR5",
                Frequency = 6000,
                Size = 32,
                Color = "Black",
                Wattage = 5
            },
            new RAM
            {
                ComponentId = Ddr5_64GbId,
                Name = "G.Skill Trident Z5 RGB 64GB 6400MHz",
                Brand = "G.Skill",
                Model = "Trident Z5 RGB 64GB (2x32GB) 6400MHz",
                CurrentPrice = 229.99m,
                IsSellable = true,
                StockQuantity = 15,
                ImageUrl = "https://example.com/images/trident-z5.jpg",
                Description = "High-capacity DDR5 memory for creators.",
                ReleaseYear = 2022,
                Type = "DDR5",
                Frequency = 6400,
                Size = 64,
                Color = "Silver",
                Wattage = 5
            },
            new RAM
            {
                ComponentId = Ddr4_32GbId,
                Name = "Crucial Ballistix DDR4 32GB 3200MHz",
                Brand = "Crucial",
                Model = "Ballistix DDR4 32GB (2x16GB) 3200MHz",
                CurrentPrice = 74.99m,
                IsSellable = true,
                StockQuantity = 25,
                ImageUrl = "https://example.com/images/ballistix-ddr4.jpg",
                Description = "Reliable DDR4 memory for budget builds.",
                ReleaseYear = 2020,
                Type = "DDR4",
                Frequency = 3200,
                Size = 32,
                Color = "Black",
                Wattage = 4
            }
        );

        await context.SaveChangesAsync();
    }
}
