using Liveeeeeeeee.Data.Context;

namespace Unit_Of_Work;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Commit()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public Task RollBack()
    {
        return Task.CompletedTask;
    }
}