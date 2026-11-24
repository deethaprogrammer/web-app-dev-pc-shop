namespace PcShop.Seeders;

using Data;
using Models.Components;

public static class CaseSeeder
{
    public const int O11DynamicId = 19;
    public const int Corsair4000DId = 20;
    public const int Nr200Id = 21;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Cases.Any())
        {
            return;
        }

        context.Cases.AddRange(
            new Case
            {
                ComponentId = O11DynamicId,
                Name = "Lian Li O11 Dynamic EVO",
                Brand = "Lian Li",
                Model = "O11 Dynamic EVO",
                CurrentPrice = 179.99m,
                IsSellable = true,
                StockQuantity = 14,
                ImageUrl = "https://example.com/images/o11d-evo.jpg",
                Description = "Popular dual-chamber ATX case with tempered glass.",
                ReleaseYear = 2021,
                FormFactorId = FormFactorSeeder.AtxId,
                Color = "Black",
                PanelType = "Tempered Glass",
                CableManagement = "Excellent",
                MaxGpuClearanceMm = 420,
                MaxCpuCoolerHeightMm = 167
            },
            new Case
            {
                ComponentId = Corsair4000DId,
                Name = "Corsair 4000D Airflow",
                Brand = "Corsair",
                Model = "4000D Airflow",
                CurrentPrice = 104.99m,
                IsSellable = true,
                StockQuantity = 20,
                ImageUrl = "https://example.com/images/4000d.jpg",
                Description = "Mid-tower ATX case focused on airflow.",
                ReleaseYear = 2020,
                FormFactorId = FormFactorSeeder.AtxId,
                Color = "White",
                PanelType = "Steel Mesh",
                CableManagement = "Good",
                MaxGpuClearanceMm = 360,
                MaxCpuCoolerHeightMm = 170
            },
            new Case
            {
                ComponentId = Nr200Id,
                Name = "Cooler Master MasterBox NR200",
                Brand = "Cooler Master",
                Model = "MasterBox NR200",
                CurrentPrice = 79.99m,
                IsSellable = true,
                StockQuantity = 16,
                ImageUrl = "https://example.com/images/nr200.jpg",
                Description = "Compact Mini-ITX case with surprising compatibility.",
                ReleaseYear = 2020,
                FormFactorId = FormFactorSeeder.MiniItxId,
                Color = "Black",
                PanelType = "Steel",
                CableManagement = "Moderate",
                MaxGpuClearanceMm = 330,
                MaxCpuCoolerHeightMm = 155
            }
        );

        await context.SaveChangesAsync();
    }
}
