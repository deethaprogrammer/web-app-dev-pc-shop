using backend.models.Orders;

namespace backend.models.Builds;

[Table("BuildBridge")]
[PrimaryKey(nameof(BuildId), nameof(OrderId))]
public class BuildBridge
{
    public Guid BuildId { get; set; }
    public Build Build { get; set; } = null!;

    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;
}