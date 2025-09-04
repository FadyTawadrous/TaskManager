using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

[Index(nameof(Name), IsUnique = true)]
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
}