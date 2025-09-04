using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<TaskItem> TaskItems { get; set; }
    public DbSet<Category> Categories { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
}