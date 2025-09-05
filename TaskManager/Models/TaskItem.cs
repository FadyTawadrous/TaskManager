using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

public class TaskItem
{
    // Task Properties
    public int TaskItemId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public TaskStatus TaskStatus { get; set; } = TaskStatus.Pending;
    public PriorityLevel PriorityLevel { get; set; } = PriorityLevel.Medium;
    public bool IsOverdue => DueDate < DateTime.UtcNow && TaskStatus != TaskStatus.Completed;


    // Many-to-1 relationship with AppUser
    [ForeignKey("AppUser")]
    public int AppUserId { get; set; }
    public virtual AppUser AppUser { get; set; }

    // Many-to-1 relationship with Category
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}