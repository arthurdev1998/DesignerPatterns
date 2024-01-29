namespace Unit_Of_Work.Data.Repositories;

public interface IEventoRepository
{
    Task IncrementarPessoa(int id);
}