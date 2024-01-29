using Liveeeeeeeee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Liveeeeeeeee.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> option): base(option){}

    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Evento> Eventos { get; set; }
}