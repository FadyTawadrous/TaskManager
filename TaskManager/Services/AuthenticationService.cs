using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

public class AuthenticationService
{
    private readonly AppDbContext _context;

    public AuthenticationService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<AppUser?> LoginAsync(string email, string password)
    {
        var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.Email.ToLowerInvariant() == email.ToLowerInvariant());
        if (user == null) return null;

        using var hmac = new HMACSHA512(user.PasswordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        if (!computedHash.SequenceEqual(user.PasswordHash))
            return null;

        return user;
    }
    public async Task<bool> RegisterAsync(string name, string email, string password)
    {
        if (await _context.AppUsers.AnyAsync(u => u.Email.ToLowerInvariant() == email.ToLowerInvariant()))
            return false;

        using var hmac = new HMACSHA512();
        var newUser = new AppUser
        {
            Name = name,
            Email = email.ToLowerInvariant(),
            PasswordSalt = hmac.Key,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password))
        };

        _context.AppUsers.Add(newUser);
        await _context.SaveChangesAsync();
        return true;
    }
}