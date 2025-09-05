using Microsoft.EntityFrameworkCore;

public class TaskService
{
    private readonly AppDbContext _context;

    public TaskService(AppDbContext context) => _context = context;

    public async Task<List<TaskItem>> GetAllAsync(int userId)
    {
        return await _context.TaskItems
            .Where(t => t.AppUserId == userId)
            .Include(t => t.Category)
            .ToListAsync();
    }
    public async Task<TaskItem?> GetTaskByIdAsync(int id) =>
        await _context.TaskItems.FindAsync(id);

    public async Task AddAsync(TaskItem task)
    {
        task.Title = task.Title.Trim();
        task.Description = task.Description.Trim();
        _context.TaskItems.Add(task);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TaskItem task)
    {
        _context.TaskItems.Update(task);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        Console.WriteLine("Deleting");
        var task = await _context.TaskItems.FindAsync(id);
        if (task is not null)
        {
            Console.WriteLine("not null");
            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();
        }
    }
}