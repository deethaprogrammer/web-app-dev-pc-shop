namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class CpuSeeder
{
    public static readonly Guid I9_14900KId = Guid.Parse("00000000-0000-0000-0000-000000000001");
    public static readonly Guid I7_14700KId = Guid.Parse("00000000-0000-0000-0000-000000000002");
    public static readonly Guid Ryzen9_7950XId = Guid.Parse("00000000-0000-0000-0000-000000000003");
    public static readonly Guid Ryzen7_7800X3DId = Guid.Parse("00000000-0000-0000-0000-000000000004");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.CPUs.Any())
        {
            return;
        }

        context.CPUs.AddRange(
            new CPU
            {
                Id = I9_14900KId,
                Name = "Intel Core i9-14900K",
                Brand = "Intel",
                Model = "Core i9-14900K",
                CurrentPrice = 589.99m,
                IsSellable = true,
                StockQuantity = 12,
                ImageUrl = "https://example.com/images/i9-14900k.jpg",
                Description = "Flagship 14th gen Intel processor for gaming and productivity.",
                ReleaseYear = 2023,
                Cores = 24,
                PerformanceCores = 8,
                Threads = 32,
                Socket = "LGA1700",
                Frequency = 3200,
                Cache = 36,
                Wattage = 125,
                HasIntegratedGraphics = true
            },
            new CPU
            {
                Id = I7_14700KId,
                Name = "Intel Core i7-14700K",
                Brand = "Intel",
                Model = "Core i7-14700K",
                CurrentPrice = 409.99m,
                IsSellable = true,
                StockQuantity = 20,
                ImageUrl = "https://example.com/images/i7-14700k.jpg",
                Description = "High-performance 14th gen Intel processor.",
                ReleaseYear = 2023,
                Cores = 20,
                PerformanceCores = 8,
                Threads = 28,
                Socket = "LGA1700",
                Frequency = 3400,
                Cache = 33,
                Wattage = 125,
                HasIntegratedGraphics = true
            },
            new CPU
            {
                Id = Ryzen9_7950XId,
                Name = "AMD Ryzen 9 7950X",
                Brand = "AMD",
                Model = "Ryzen 9 7950X",
                CurrentPrice = 549.99m,
                IsSellable = true,
                StockQuantity = 8,
                ImageUrl = "https://example.com/images/ryzen9-7950x.jpg",
                Description = "16-core powerhouse based on Zen 4 architecture.",
                ReleaseYear = 2022,
                Cores = 16,
                Threads = 32,
                Socket = "AM5",
                Frequency = 4500,
                Cache = 64,
                Wattage = 170,
                HasIntegratedGraphics = false
            },
            new CPU
            {
                Id = Ryzen7_7800X3DId,
                Name = "AMD Ryzen 7 7800X3D",
                Brand = "AMD",
                Model = "Ryzen 7 7800X3D",
                CurrentPrice = 449.99m,
                IsSellable = true,
                StockQuantity = 15,
                ImageUrl = "https://example.com/images/ryzen7-7800x3d.jpg",
                Description = "Best gaming CPU with 3D V-Cache technology.",
                ReleaseYear = 2023,
                Cores = 8,
                Threads = 16,
                Socket = "AM5",
                Frequency = 4200,
                Cache = 96,
                Wattage = 120,
                HasIntegratedGraphics = false
            }
        );

        await context.SaveChangesAsync();
    }
}
