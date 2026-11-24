namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class StickerSeeder
{
    public static readonly Guid PcMasterRaceId = Guid.Parse("00000000-0000-0000-0000-000000000030");
    public static readonly Guid RgbLogoId = Guid.Parse("00000000-0000-0000-0000-000000000031");
    public static readonly Guid TechStickerId = Guid.Parse("00000000-0000-0000-0000-000000000032");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Stickers.Any())
        {
            return;
        }

        context.Stickers.AddRange(
            new Sticker
            {
                Id = PcMasterRaceId,
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
                Id = RgbLogoId,
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
                Id = TechStickerId,
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
