namespace PcShop.Seeders;

using Data;
using Models.Identity;

public static class UserSeeder
{
    public const int AdminId = 1;
    public const int JohnId = 2;
    public const int JaneId = 3;

    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Users.Any())
        {
            return;
        }

        context.Users.AddRange(
            new User
            {
                UserId = AdminId,
                Name = "Administrator",
                Username = "admin",
                EmailAddress = "admin@pcshop.local",
                PasswordHash = "$2a$11$adminHashedPasswordPlaceholder",
                RoleLevel = 3,
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                UserId = JohnId,
                Name = "John Doe",
                Username = "john_doe",
                EmailAddress = "john@example.com",
                PasswordHash = "$2a$11$johnHashedPasswordPlaceholder",
                RoleLevel = 1,
                CreatedAt = new DateTime(2024, 2, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new User
            {
                UserId = JaneId,
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
