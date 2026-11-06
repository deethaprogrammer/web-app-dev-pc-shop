namespace PcShop.Models.Builds;

using Models.Identity;

[Table("Build")]
public class Build
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid BuildId { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    [Precision(10, 2)]
    public decimal CalculatedPrice { get; set; }

    [Required]
    public string Name { get; set; } = ""; //name of the build not name of the user
}
