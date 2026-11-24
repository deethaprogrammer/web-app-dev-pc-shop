namespace PcShop.Models.Orders;

using Models.Identity;

public enum OrderStatus
{
    Pending = 0,
    Processing = 1,
    Shipped = 2,
    Delivered = 3,
    Cancelled = 4
}

[Table("Order")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;

    public OrderStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    [Required]
    public string Shippingaddress { get; set; } = null!;

    [Precision(10, 2)]
    public decimal Price { get; set; }

    public int Warranty { get; set; } = 2;
}
