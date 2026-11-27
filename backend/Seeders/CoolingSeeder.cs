namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class CoolingSeeder
{
    public static readonly Guid NhD15Id = Guid.Parse("00000000-0000-0000-0000-000000000022");
    public static readonly Guid Kraken360Id = Guid.Parse("00000000-0000-0000-0000-000000000023");
    public static readonly Guid Hyper212Id = Guid.Parse("00000000-0000-0000-0000-000000000024");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Coolings.Any())
        {
            return;
        }

        context.Coolings.AddRange(
            new Cooling
            {
                Id = NhD15Id,
                Name = "Noctua NH-D15 chromax.Black",
                Brand = "Noctua",
                Model = "NH-D15 chromax.Black",
                CurrentPrice = 109.99m,
                IsSellable = true,
                StockQuantity = 12,
                ImageUrl = "https://example.com/images/nh-d15.jpg",
                Description = "Dual-tower air cooler with excellent acoustics.",
                ReleaseYear = 2021,
                Type = "Air",
                HeightMm = 165
            },
            new Cooling
            {
                Id = Kraken360Id,
                Name = "NZXT Kraken 360 RGB",
                Brand = "NZXT",
                Model = "Kraken 360 RGB",
                CurrentPrice = 249.99m,
                IsSellable = true,
                StockQuantity = 8,
                ImageUrl = "https://example.com/images/kraken360.jpg",
                Description = "360mm AIO liquid cooler with RGB fans.",
                ReleaseYear = 2023,
                Type = "AIO",
                HeightMm = null
            },
            new Cooling
            {
                Id = Hyper212Id,
                Name = "Cooler Master Hyper 212 Black Edition",
                Brand = "Cooler Master",
                Model = "Hyper 212 Black Edition",
                CurrentPrice = 39.99m,
                IsSellable = true,
                StockQuantity = 30,
                ImageUrl = "https://example.com/images/hyper212.jpg",
                Description = "Affordable and reliable tower air cooler.",
                ReleaseYear = 2019,
                Type = "Air",
                HeightMm = 158
            }
        );

        await context.SaveChangesAsync();
    }
}
