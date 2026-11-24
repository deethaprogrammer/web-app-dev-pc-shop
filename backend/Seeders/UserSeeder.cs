namespace PcShop.Seeders;

using Data;
using Models.Identity;

public static class UserSeeder
{
    public static readonly Guid AdminId = Guid.Parse("10000000-0000-0000-0000-000000000001");
    public static readonly Guid JohnId = Guid.Parse("10000000-0000-0000-0000-000000000002");
    public static readonly Guid JaneId = Guid.Parse("10000000-0000-0000-0000-000000000003");

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Users.Any())
        {
            return;
        }

        context.Users.AddRange(
            new User
            {
                Id = AdminId,
                Name = "Administrator",
                Username = "admin",
                EmailAddress = "admin@pcshop.local",
                PasswordHash = "$2a$11$adminHashedPasswordPlaceholder",
                RoleLevel = 3,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = JohnId,
                Name = "John Doe",
                Username = "john_doe",
                EmailAddress = "john@example.com",
                PasswordHash = "$2a$11$johnHashedPasswordPlaceholder",
                RoleLevel = 1,
                CreatedAt = new DateTime(2024, 2, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                Id = JaneId,
                Name = "Jane Doe",
                Username = "jane_doe",
                EmailAddress = "jane@example.com",
                PasswordHash = "$2a$11$janeHashedPasswordPlaceholder",
                RoleLevel = 1,
                CreatedAt = new DateTime(2024, 3, 10, 0, 0, 0, DateTimeKind.Utc)
            }
        );

        await context.SaveChangesAsync();
    }
}
