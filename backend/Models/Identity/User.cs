namespace PcShop.Models.Identity;

[Table("User")]
[Index(nameof(EmailAddress), IsUnique = true)]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid UserId { get; set; }

    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string EmailAddress { get; set; } = null!;

    [Required]
    public string PasswordHash { get; set; } = null!;

    public int RoleLevel { get; set; }

    public DateTime CreatedAt { get; set; }
}
