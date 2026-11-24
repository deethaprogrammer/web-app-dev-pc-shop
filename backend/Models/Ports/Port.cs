namespace PcShop.Models.Ports;

[Table("Port")]
public class Port : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Type { get; set; } = null!;

    public string? Version { get; set; }
}
