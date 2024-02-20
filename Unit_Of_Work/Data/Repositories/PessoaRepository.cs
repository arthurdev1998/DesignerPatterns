using Liveeeeeeeee.Data.Context;
using Liveeeeeeeee.Entities;

namespace Unit_Of_Work.Data.Repositories;

public class PessoaRepository : IPessoaRepository
{
    private readonly AppDbContext _context;

    public PessoaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Pessoa> AdicionarPessoa(Pessoa pessoa)
    {
        await _context.Pessoas.AddAsync(pessoa);
    }
}