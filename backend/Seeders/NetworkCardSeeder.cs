namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class NetworkCardSeeder
{
    public static readonly Guid Ax210Id = Guid.Parse("00000000-0000-0000-0000-000000000028");
    public static readonly Guid Ax200Id = Guid.Parse("00000000-0000-0000-0000-000000000029");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.NetworkCards.Any())
        {
            return;
        }

        context.NetworkCards.AddRange(
            new NetworkCard
            {
                Id = Ax210Id,
                Name = "Intel Wi-Fi 6E AX210",
                Brand = "Intel",
                Model = "Wi-Fi 6E AX210",
                CurrentPrice = 29.99m,
                IsSellable = true,
                StockQuantity = 20,
                ImageUrl = "https://example.com/images/ax210.jpg",
                Description = "Tri-band Wi-Fi 6E adapter with Bluetooth 5.3.",
                ReleaseYear = 2021,
                WifiType = "Wi-Fi 6E",
                BluetoothType = "5.3",
                MaxSpeed = 2400,
                PcieLevel = 3
            },
            new NetworkCard
            {
                Id = Ax200Id,
                Name = "Intel Wi-Fi 6 AX200",
                Brand = "Intel",
                Model = "Wi-Fi 6 AX200",
                CurrentPrice = 24.99m,
                IsSellable = true,
                StockQuantity = 25,
                ImageUrl = "https://example.com/images/ax200.jpg",
                Description = "Dual-band Wi-Fi 6 adapter with Bluetooth 5.2.",
                ReleaseYear = 2019,
                WifiType = "Wi-Fi 6",
                BluetoothType = "5.2",
                MaxSpeed = 2400,
                PcieLevel = 3
            }
        );

        await context.SaveChangesAsync();
    }
}
