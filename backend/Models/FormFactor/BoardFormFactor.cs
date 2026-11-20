namespace PcShop.Models.FormFactor;

using Models.Components;

[Table("BoardFormFactor")]
public class BoardFormFactor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public int SizeClass { get; set; }

    public ICollection<Motherboard> Motherboards { get; set; } = new List<Motherboard>();
    public ICollection<Case> Cases { get; set; } = new List<Case>();
}
