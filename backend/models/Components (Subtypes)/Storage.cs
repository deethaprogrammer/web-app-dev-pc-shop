using backend.models.Base;
using backend.models.FormFactor;

namespace backend.models.Components;

[Table("Storage")] 
public class Storage : PcComponent
{
    public Storage()
    {
        ComponentType = "Storage";
    }
    public Guid FormFactorId { get; set; }

    public StorageFormFactor FormFactor { get; set; } = null!;

    public int StorageSize { get; set; }

    public int Speed { get; set; }

    public int Type { get; set; }

    public int? Heatsink { get; set; }

    public int Wattage { get; set; }

}