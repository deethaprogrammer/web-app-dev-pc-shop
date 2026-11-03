namespace PcShop.Models.Builds;

using Models.Components;

[Table("CustomDesign")]
public class CustomDesign
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CustomDesignId { get; set; }

    public Guid CaseComponentId { get; set; }
    public Case CaseComponent { get; set; } = null!;

    public Guid StickerId { get; set; }
    public Sticker Sticker { get; set; } = null!;

    public Guid BuildId { get; set; }
    public Build Build { get; set; } = null!;

    [Required]
    public string SideLocation { get; set; } = null!;

    public int XAxis { get; set; }

    public int YAxis { get; set; }

    public int RotationDegree { get; set; }
}
