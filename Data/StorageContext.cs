using Microsoft.EntityFrameworkCore;

public class StorageContext(DbContextOptions<StorageContext> options) : DbContext(options)
{
    public DbSet<StorageAPI.Models.Product> Product { get; set; } = default!;
}
