using Microsoft.EntityFrameworkCore;

namespace TODOList.Data;

public class dbContext : DbContext
{
    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Todo> TODOs { get; set; } 
}