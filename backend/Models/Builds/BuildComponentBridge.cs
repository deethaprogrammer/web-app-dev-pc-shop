namespace PcShop.Models.Builds;

using Models.Base;


[Table("BuildComponentBridge")]
[PrimaryKey(nameof(BuildId), nameof(ComponentId))]
public class BuildComponentBridge
{
    public Guid BuildId { get; set; }
    public Build Build { get; set; } = null!;

    public Guid ComponentId { get; set; }
    public PcComponent PcComponent { get; set; } = null!;

    public int Quantity { get; set; }
}
