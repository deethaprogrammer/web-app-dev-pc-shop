namespace PcShop.Models.Components;

using PcShop.Models.Base;
using PcShop.Models.FormFactor;

[Table("Case")]
public class Case : PcComponent
{
    public Case()
    {
        ComponentType = "Case";
    }
    public Guid FormFactorId { get; set; }

    public BoardFormFactor FormFactor { get; set; } = null!;

    [Required]
    public string Color { get; set; } = null!;

    [Required]
    public string PanelType { get; set; } = null!;

    public string? CableManagement { get; set; }

    public int MaxGpuClearanceMm { get; set; }

    public int MaxCpuCoolerHeightMm { get; set; }

}
