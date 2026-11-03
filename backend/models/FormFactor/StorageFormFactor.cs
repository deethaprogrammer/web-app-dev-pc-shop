using backend.models.Components;

namespace backend.models.FormFactor;

[Table("StorageFormFactor")]
public class StorageFormFactor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public ICollection<Storage> Storages { get; set; } = new List<Storage>();
}