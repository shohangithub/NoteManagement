namespace Domain.Entities;

[Table("Users")]
public class User : BaseEntity<int>
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string DOB { get; set; }
    public required string Password { get; set; }
}