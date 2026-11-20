namespace PcShop.Dtos.FormFactor;

public record BoardFormFactorDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public int SizeClass { get; init; }
}

public record CreateBoardFormFactorDto
{
    public string Name { get; init; } = string.Empty;
    public int SizeClass { get; init; }
}

public record UpdateBoardFormFactorDto
{
    public string Name { get; init; } = string.Empty;
    public int SizeClass { get; init; }
}
