namespace PcShop.Models.Builds;

using Models.Orders;


[Table("BuildBridge")]
[PrimaryKey(nameof(BuildId), nameof(OrderId))]
public class BuildBridge
{
    public Guid BuildId { get; set; }
    public Build Build { get; set; } = null!;

    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;
}
