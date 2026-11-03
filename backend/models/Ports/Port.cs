namespace backend.models.Ports;

[Table("Port")]
public class Port
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PortId { get; set; }
    
    [Required]
    public string Type { get; set; } = null!;

    public string? Version { get; set; }
}