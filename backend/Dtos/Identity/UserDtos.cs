namespace PcShop.Dtos.Identity;

public record UserDto
{
    public Guid UserId { get; init; }
    public string Username { get; init; } = string.Empty;
    public string EmailAddress { get; init; } = string.Empty;
    public int RoleLevel { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record CreateUserDto
{
    public string Username { get; init; } = string.Empty;
    public string EmailAddress { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}

public record UpdateUserDto
{
    public string Username { get; init; } = string.Empty;
    public string EmailAddress { get; init; } = string.Empty;
    public int RoleLevel { get; init; }
}
