namespace PcShop.Seeders;

using Data;
using Models.Builds;

public static class BuildSeeder
{
    public const int GamingBuildId = 1;
    public const int WorkstationBuildId = 2;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Builds.Any())
        {
            return;
        }

        var gamingBuild = new Build
        {
            BuildId = GamingBuildId,
            UserId = UserSeeder.JohnId,
            Name = "Ultimate Gaming Rig",
            CalculatedPrice = 3249.90m
        };

        var workstationBuild = new Build
        {
            BuildId = WorkstationBuildId,
            UserId = UserSeeder.JaneId,
            Name = "Content Creation Workstation",
            CalculatedPrice = 2849.92m
        };

        context.Builds.AddRange(gamingBuild, workstationBuild);
        await context.SaveChangesAsync();

        var gamingComponents = new[]
        {
            (CpuSeeder.Ryzen7_7800X3DId, 1),
            (GpuSeeder.Rtx4090Id, 1),
            (MotherboardSeeder.B650eFId, 1),
            (RamSeeder.Ddr5_32GbId, 1),
            (StorageSeeder.Sn850x2TbId, 1),
            (CaseSeeder.O11DynamicId, 1),
            (CoolingSeeder.Kraken360Id, 1),
            (PsuSeeder.Rm1000XId, 1)
        };

        var workstationComponents = new[]
        {
            (CpuSeeder.I9_14900KId, 1),
            (GpuSeeder.Rtx4080Id, 1),
            (MotherboardSeeder.Z790HeroId, 1),
            (RamSeeder.Ddr5_64GbId, 2),
            (StorageSeeder.Samsung990Pro1TbId, 2),
            (StorageSeeder.Barracuda4TbId, 1),
            (CaseSeeder.Corsair4000DId, 1),
            (CoolingSeeder.NhD15Id, 1),
            (PsuSeeder.FocusGx850Id, 1)
        };

        AddComponents(context, gamingBuild.BuildId, gamingComponents);
        AddComponents(context, workstationBuild.BuildId, workstationComponents);

        context.CustomDesigns.AddRange(
            new CustomDesign
            {
                CustomDesignId = 1,
                Name = "Front PCMR Sticker",
                BuildId = gamingBuild.BuildId,
                CaseComponentId = CaseSeeder.O11DynamicId,
                StickerId = StickerSeeder.PcMasterRaceId,
                SideLocation = "Front",
                XAxis = 120,
                YAxis = 80,
                RotationDegree = 0
            }
        );

        await context.SaveChangesAsync();
    }

    private static void AddComponents(AppDbContext context, int buildId, IEnumerable<(int ComponentId, int Quantity)> components)
    {
        foreach (var (componentId, quantity) in components)
        {
            context.BuildComponentBridges.Add(new BuildComponentBridge
            {
                BuildId = buildId,
                ComponentId = componentId,
                Quantity = quantity
            });
        }
    }
}
