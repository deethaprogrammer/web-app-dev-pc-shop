namespace PcShop.Dtos.Components;

using Dtos.Base;

public record StickerDto : PcComponentDto
{
    public int WidthMm { get; init; }
    public int HeightMm { get; init; }
}

public record CreateStickerDto : CreatePcComponentDto
{
    public int WidthMm { get; init; }
    public int HeightMm { get; init; }
}

public record UpdateStickerDto : UpdatePcComponentDto
{
    public int WidthMm { get; init; }
    public int HeightMm { get; init; }
}
