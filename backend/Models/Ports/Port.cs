namespace PcShop.Models.Ports;

[Table("Port")]
public class Port : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    [Required]
    public string Name { get; set; } = null!;
    public Guid Id { get; set; }

    [Required]
    public string Type { get; set; } = null!;

    public string? Version { get; set; }
}
