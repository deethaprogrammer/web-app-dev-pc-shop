namespace PcShop.Models.Components;

using Models.Base;

public enum ModularType
{
    NonModular = 0,
    SemiModular = 1,
    FullModular = 2
}

[Table("PSU")]
public class PSU : PcComponent
{
    public PSU()
    {
        ComponentType = "PSU";
    }

    public int Wattage { get; set; }

    public string? Rating { get; set; }

    public ModularType Modular { get; set; }
}
