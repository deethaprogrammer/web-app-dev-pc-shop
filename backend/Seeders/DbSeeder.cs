namespace PcShop.Seeders;

using Data;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        await FormFactorSeeder.SeedAsync(context);
        await PortSeeder.SeedAsync(context);
        await UserSeeder.SeedAsync(context);

        await CpuSeeder.SeedAsync(context);
        await GpuSeeder.SeedAsync(context);
        await MotherboardSeeder.SeedAsync(context);
        await PortsBridgeSeeder.SeedAsync(context);
        await RamSeeder.SeedAsync(context);
        await StorageSeeder.SeedAsync(context);
        await CaseSeeder.SeedAsync(context);
        await CoolingSeeder.SeedAsync(context);
        await PsuSeeder.SeedAsync(context);
        await NetworkCardSeeder.SeedAsync(context);
        await StickerSeeder.SeedAsync(context);

        await BuildSeeder.SeedAsync(context);
        await OrderSeeder.SeedAsync(context);

        await context.SaveChangesAsync();
    }
}
