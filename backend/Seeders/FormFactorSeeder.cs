namespace PcShop.Seeders;

using Data;
using Models.FormFactor;

public static class FormFactorSeeder
{
    public static readonly Guid AtxId = Guid.Parse("20000000-0000-0000-0000-000000000001");
    public static readonly Guid MicroAtxId = Guid.Parse("20000000-0000-0000-0000-000000000002");
    public static readonly Guid MiniItxId = Guid.Parse("20000000-0000-0000-0000-000000000003");
    public static readonly Guid EAtxId = Guid.Parse("20000000-0000-0000-0000-000000000004");

    public static readonly Guid Ssd25Id = Guid.Parse("21000000-0000-0000-0000-000000000001");
    public static readonly Guid Ssd35Id = Guid.Parse("21000000-0000-0000-0000-000000000002");
    public static readonly Guid M2_2280Id = Guid.Parse("21000000-0000-0000-0000-000000000003");
    public static readonly Guid M2_22110Id = Guid.Parse("21000000-0000-0000-0000-000000000004");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.BoardFormFactors.Any())
        {
            context.BoardFormFactors.AddRange(
                new BoardFormFactor { Id = AtxId, Name = "ATX", SizeClass = 3 },
                new BoardFormFactor { Id = MicroAtxId, Name = "Micro-ATX", SizeClass = 2 },
                new BoardFormFactor { Id = MiniItxId, Name = "Mini-ITX", SizeClass = 1 },
                new BoardFormFactor { Id = EAtxId, Name = "E-ATX", SizeClass = 4 }
            );
            await context.SaveChangesAsync();
        }

        if (!context.StorageFormFactors.Any())
        {
            context.StorageFormFactors.AddRange(
                new StorageFormFactor { Id = Ssd25Id, Name = "2.5\" SSD" },
                new StorageFormFactor { Id = Ssd35Id, Name = "3.5\" HDD" },
                new StorageFormFactor { Id = M2_2280Id, Name = "M.2 2280" },
                new StorageFormFactor { Id = M2_22110Id, Name = "M.2 22110" }
            );
            await context.SaveChangesAsync();
        }
    }
}
