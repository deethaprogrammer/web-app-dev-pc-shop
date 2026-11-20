namespace PcShop.Dtos.FormFactor;

public record StorageFormFactorDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
}

public record CreateStorageFormFactorDto
{
    public string Name { get; init; } = string.Empty;
}

public record UpdateStorageFormFactorDto
{
    public string Name { get; init; } = string.Empty;
}
