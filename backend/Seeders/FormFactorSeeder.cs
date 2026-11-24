namespace PcShop.Seeders;

using Data;
using Models.FormFactor;

public static class FormFactorSeeder
{
    public const int AtxId = 1;
    public const int MicroAtxId = 2;
    public const int MiniItxId = 3;
    public const int EAtxId = 4;

    public const int Ssd25Id = 1;
    public const int Ssd35Id = 2;
    public const int M2_2280Id = 3;
    public const int M2_22110Id = 4;

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
