namespace PcShop.Models.Base;

[Table("PcComponent")]
public abstract class PcComponent
{
    // unique ID, shared with the subtype table
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ComponentId { get; set; }

    // kind of part, e.g. "CPU", "GPU", "Sticker"
    [Required]
    public string ComponentType { get; protected set; } = null!;

    [Required]
    public string Brand { get; set; } = null!;

    [Required]
    public string Model { get; set; } = null!;

    [Precision(10, 2)]
    public decimal CurrentPrice { get; set; }

    public bool IsSellable { get; set; } = true;

    public int StockQuantity { get; set; }

    [Required]
    public string ImageUrl { get; set; } = null!;

    public string Description { get; set; } = "";

    public int ReleaseYear { get; set; }
}
