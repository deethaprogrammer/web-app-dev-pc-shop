namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class GpuSeeder
{
    public static readonly Guid Rtx4090Id = Guid.Parse("00000000-0000-0000-0000-000000000005");
    public static readonly Guid Rtx4080Id = Guid.Parse("00000000-0000-0000-0000-000000000006");
    public static readonly Guid Rx7900XtxId = Guid.Parse("00000000-0000-0000-0000-000000000007");
    public static readonly Guid Rtx4070Id = Guid.Parse("00000000-0000-0000-0000-000000000008");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.GPUs.Any())
        {
            return;
        }

        context.GPUs.AddRange(
            new GPU
            {
                Id = Rtx4090Id,
                Name = "NVIDIA GeForce RTX 4090",
                Brand = "NVIDIA",
                Model = "GeForce RTX 4090",
                CurrentPrice = 1599.99m,
                IsSellable = true,
                StockQuantity = 5,
                ImageUrl = "https://example.com/images/rtx4090.jpg",
                Description = "Ultimate 4K gaming and creator GPU.",
                ReleaseYear = 2022,
                VulkanVersion = 1.3,
                OpenglVersion = 4.6,
                CudaCores = 16384,
                Cores = 16384,
                VramAmount = 24,
                VramType = "GDDR6X",
                Frequency = 2235,
                Wattage = 450,
                Cooling = "Triple fan",
                FansAmount = 3,
                Overclockable = true,
                BiosLock = false,
                Color = "Black",
                LengthMm = 336
            },
            new GPU
            {
                Id = Rtx4080Id,
                Name = "NVIDIA GeForce RTX 4080",
                Brand = "NVIDIA",
                Model = "GeForce RTX 4080",
                CurrentPrice = 1199.99m,
                IsSellable = true,
                StockQuantity = 9,
                ImageUrl = "https://example.com/images/rtx4080.jpg",
                Description = "High-end 4K gaming GPU.",
                ReleaseYear = 2022,
                VulkanVersion = 1.3,
                OpenglVersion = 4.6,
                CudaCores = 9728,
                Cores = 9728,
                VramAmount = 16,
                VramType = "GDDR6X",
                Frequency = 2210,
                Wattage = 320,
                Cooling = "Triple fan",
                FansAmount = 3,
                Overclockable = true,
                BiosLock = false,
                Color = "Black",
                LengthMm = 310
            },
            new GPU
            {
                Id = Rx7900XtxId,
                Name = "AMD Radeon RX 7900 XTX",
                Brand = "AMD",
                Model = "Radeon RX 7900 XTX",
                CurrentPrice = 999.99m,
                IsSellable = true,
                StockQuantity = 7,
                ImageUrl = "https://example.com/images/rx7900xtx.jpg",
                Description = "AMD flagship GPU with excellent price-to-performance.",
                ReleaseYear = 2022,
                VulkanVersion = 1.3,
                OpenglVersion = 4.6,
                Cores = 6144,
                VramAmount = 24,
                VramType = "GDDR6",
                Frequency = 2300,
                Wattage = 355,
                Cooling = "Triple fan",
                FansAmount = 3,
                Overclockable = true,
                BiosLock = false,
                Color = "Silver",
                LengthMm = 287
            },
            new GPU
            {
                Id = Rtx4070Id,
                Name = "NVIDIA GeForce RTX 4070",
                Brand = "NVIDIA",
                Model = "GeForce RTX 4070",
                CurrentPrice = 599.99m,
                IsSellable = true,
                StockQuantity = 14,
                ImageUrl = "https://example.com/images/rtx4070.jpg",
                Description = "Great 1440p gaming GPU with DLSS 3.",
                ReleaseYear = 2023,
                VulkanVersion = 1.3,
                OpenglVersion = 4.6,
                CudaCores = 5888,
                Cores = 5888,
                VramAmount = 12,
                VramType = "GDDR6X",
                Frequency = 1920,
                Wattage = 200,
                Cooling = "Dual fan",
                FansAmount = 2,
                Overclockable = true,
                BiosLock = false,
                Color = "White",
                LengthMm = 240
            }
        );

        await context.SaveChangesAsync();
    }
}
