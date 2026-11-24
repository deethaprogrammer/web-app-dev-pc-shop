namespace PcShop.Seeders;

using Data;
using Models.Builds;
using Models.Orders;

public static class OrderSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Orders.Any())
        {
            return;
        }

        var order1 = new Order
        {
            OrderId = 1,
            UserId = UserSeeder.JohnId,
            Name = "John's Gaming Rig Order",
            Status = OrderStatus.Shipped,
            CreatedAt = new DateTime(2024, 4, 1, 10, 0, 0, DateTimeKind.Utc),
            UpdatedAt = new DateTime(2024, 4, 3, 14, 30, 0, DateTimeKind.Utc),
            Shippingaddress = "123 Gaming Lane, New York, NY 10001",
            Price = 3249.90m,
            Warranty = 2
        };

        var order2 = new Order
        {
            OrderId = 2,
            UserId = UserSeeder.JaneId,
            Name = "Jane's Workstation Order",
            Status = OrderStatus.Processing,
            CreatedAt = new DateTime(2024, 4, 5, 9, 15, 0, DateTimeKind.Utc),
            UpdatedAt = new DateTime(2024, 4, 6, 11, 0, 0, DateTimeKind.Utc),
            Shippingaddress = "456 Creator Ave, Los Angeles, CA 90001",
            Price = 2849.92m,
            Warranty = 3
        };

        var order3 = new Order
        {
            OrderId = 3,
            UserId = UserSeeder.AdminId,
            Name = "Admin RTX 4090 Order",
            Status = OrderStatus.Pending,
            CreatedAt = new DateTime(2024, 4, 10, 16, 45, 0, DateTimeKind.Utc),
            UpdatedAt = new DateTime(2024, 4, 10, 16, 45, 0, DateTimeKind.Utc),
            Shippingaddress = "789 Admin Blvd, Seattle, WA 98101",
            Price = 1599.99m,
            Warranty = 2
        };

        context.Orders.AddRange(order1, order2, order3);
        await context.SaveChangesAsync();

        context.BuildBridges.AddRange(
            new BuildBridge { BuildId = BuildSeeder.GamingBuildId, OrderId = order1.OrderId },
            new BuildBridge { BuildId = BuildSeeder.WorkstationBuildId, OrderId = order2.OrderId }
        );

        await context.SaveChangesAsync();
    }
}
