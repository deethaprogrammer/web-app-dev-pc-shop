namespace PcShop.Models.FormFactor;

using Models.Components;

[Table("StorageFormFactor")]
public class StorageFormFactor : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public ICollection<Storage> Storages { get; set; } = new List<Storage>();
}
