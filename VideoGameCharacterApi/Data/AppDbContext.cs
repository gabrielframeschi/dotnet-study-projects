using Microsoft.EntityFrameworkCore;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // DbSet "=" Table, 'Characters' is the name of the Table
    public DbSet<Character> Characters => Set<Character>();
}
