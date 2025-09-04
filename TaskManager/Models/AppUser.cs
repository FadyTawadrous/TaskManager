using System.ComponentModel.DataAnnotations;

public class AppUser
{
    // User Properties
    [Key]
    public int AppUserId { get; set; }
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

    // One-to-many relationship with TaskItem
    public virtual ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
}