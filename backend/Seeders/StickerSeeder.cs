namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class StickerSeeder
{
    public const int PcMasterRaceId = 30;
    public const int RgbLogoId = 31;
    public const int TechStickerId = 32;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Stickers.Any())
        {
            return;
        }

        context.Stickers.AddRange(
            new Sticker
            {
                ComponentId = PcMasterRaceId,
                Name = "PC Master Race Glorious Sticker",
                Brand = "PCMR",
                Model = "Glorious Sticker",
                CurrentPrice = 4.99m,
                IsSellable = true,
                StockQuantity = 100,
                ImageUrl = "https://example.com/images/pcmr-sticker.jpg",
                Description = "Classic PC Master Race sticker.",
                ReleaseYear = 2020,
                WidthMm = 80,
                HeightMm = 80
            },
            new Sticker
            {
                ComponentId = RgbLogoId,
                Name = "RGB Rainbow Logo Sticker",
                Brand = "RGB",
                Model = "Rainbow Logo Sticker",
                CurrentPrice = 3.99m,
                IsSellable = true,
                StockQuantity = 100,
                ImageUrl = "https://example.com/images/rgb-sticker.jpg",
                Description = "Vibrant RGB-themed logo sticker.",
                ReleaseYear = 2021,
                WidthMm = 60,
                HeightMm = 60
            },
            new Sticker
            {
                ComponentId = TechStickerId,
                Name = "Tech Circuit Board Sticker",
                Brand = "Tech",
                Model = "Circuit Board Sticker",
                CurrentPrice = 2.99m,
                IsSellable = true,
                StockQuantity = 100,
                ImageUrl = "https://example.com/images/circuit-sticker.jpg",
                Description = "Green circuit board pattern sticker.",
                ReleaseYear = 2021,
                WidthMm = 70,
                HeightMm = 50
            }
        );

        await context.SaveChangesAsync();
    }
}
