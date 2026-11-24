namespace PcShop.Models.Components;

using Models.Base;
using Models.FormFactor;

public enum StorageType
{
    Ssd = 0,
    Hdd = 1,
    Nvme = 2,
    Sshd = 3
}

[Table("Storage")]
public class Storage : PcComponent
{
    public Storage()
    {
        ComponentType = "Storage";
    }
    public int FormFactorId { get; set; }

    public StorageFormFactor FormFactor { get; set; } = null!;

    public int StorageSize { get; set; }

    public int Speed { get; set; }

    public StorageType Type { get; set; }

    public bool? HasHeatsink { get; set; }

    public int Wattage { get; set; }

}
