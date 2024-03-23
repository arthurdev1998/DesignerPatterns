using Microsoft.EntityFrameworkCore;

namespace CqrsMediatr.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {}
    
       
}