using backend.models.Base;

namespace backend.models.Components;

[Table("PSU")] 
public class PSU : PcComponent
{
    public PSU()
    {
        ComponentType = "PSU";
    }

    public int Wattage { get; set; }

    public string? Rating { get; set; }

    public int Modular { get; set; }
}