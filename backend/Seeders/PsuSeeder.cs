namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class PsuSeeder
{
    public static readonly Guid Rm1000XId = Guid.Parse("00000000-0000-0000-0000-000000000025");
    public static readonly Guid FocusGx850Id = Guid.Parse("00000000-0000-0000-0000-000000000026");
    public static readonly Guid Cx750Id = Guid.Parse("00000000-0000-0000-0000-000000000027");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.PSUs.Any())
        {
            return;
        }

        context.PSUs.AddRange(
            new PSU
            {
                Id = Rm1000XId,
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
                Id = FocusGx850Id,
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
                Id = Cx750Id,
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
