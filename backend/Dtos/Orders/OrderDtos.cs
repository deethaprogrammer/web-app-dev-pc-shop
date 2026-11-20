namespace PcShop.Dtos.Orders;

public record OrderDto
{
    public Guid OrderId { get; init; }
    public Guid UserId { get; init; }
    public int Status { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
    public string Shippingaddress { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public int Warranty { get; init; }
}

public record CreateOrderDto
{
    public Guid UserId { get; init; }
    public int Status { get; init; }
    public string Shippingaddress { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public int Warranty { get; init; } = 2;
}

public record UpdateOrderDto
{
    public int Status { get; init; }
    public string Shippingaddress { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public int Warranty { get; init; }
}
