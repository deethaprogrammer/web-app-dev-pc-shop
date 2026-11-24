namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class PsuSeeder
{
    public const int Rm1000XId = 25;
    public const int FocusGx850Id = 26;
    public const int Cx750Id = 27;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.PSUs.Any())
        {
            return;
        }

        context.PSUs.AddRange(
            new PSU
            {
                ComponentId = Rm1000XId,
                Name = "Corsair RM1000x SHIFT",
                Brand = "Corsair",
                Model = "RM1000x SHIFT",
                CurrentPrice = 199.99m,
                IsSellable = true,
                StockQuantity = 10,
                ImageUrl = "https://example.com/images/rm1000x.jpg",
                Description = "1000W ATX 3.0 power supply with side-mounted connectors.",
                ReleaseYear = 2023,
                Wattage = 1000,
                Rating = "80 Plus Gold",
                Modular = ModularType.FullModular
            },
            new PSU
            {
                ComponentId = FocusGx850Id,
                Name = "Seasonic FOCUS GX-850",
                Brand = "Seasonic",
                Model = "FOCUS GX-850",
                CurrentPrice = 139.99m,
                IsSellable = true,
                StockQuantity = 15,
                ImageUrl = "https://example.com/images/focus-gx850.jpg",
                Description = "Reliable 850W fully modular PSU.",
                ReleaseYear = 2021,
                Wattage = 850,
                Rating = "80 Plus Gold",
                Modular = ModularType.FullModular
            },
            new PSU
            {
                ComponentId = Cx750Id,
                Name = "Corsair CX750M",
                Brand = "Corsair",
                Model = "CX750M",
                CurrentPrice = 89.99m,
                IsSellable = true,
                StockQuantity = 25,
                ImageUrl = "https://example.com/images/cx750m.jpg",
                Description = "Budget-friendly 750W semi-modular PSU.",
                ReleaseYear = 2020,
                Wattage = 750,
                Rating = "80 Plus Bronze",
                Modular = ModularType.SemiModular
            }
        );

        await context.SaveChangesAsync();
    }
}
