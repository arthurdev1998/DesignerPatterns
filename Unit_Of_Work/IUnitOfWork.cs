namespace Unit_Of_Work;

public interface IUnitOfWork
{
    Task<bool> Commit();
    Task RollBack();
}