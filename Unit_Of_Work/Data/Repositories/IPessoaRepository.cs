using Liveeeeeeeee.Entities;

namespace Unit_Of_Work.Data.Repositories;

public interface IPessoaRepository
{
    Task AdicionarPessoa(Pessoa pessoa);
}