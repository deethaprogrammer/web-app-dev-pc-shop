using backend.models.Identity;

namespace backend.models.Orders;
[Table("Order")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid OrderId { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    [Required]
    public string Shippingaddress { get; set; } = null!;

    [Precision(10, 2)]
    public decimal Price { get; set; }

    public int Warranty { get; set; } = 2;
}