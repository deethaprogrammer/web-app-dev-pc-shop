namespace PcShop.Models.FormFactor;

using Models.Components;

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
