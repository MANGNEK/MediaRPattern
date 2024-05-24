namespace MediaR.Domain.Ufw;

public interface IUnitOfWork
{
    IDisposable Session { get; }

    void AddOperation(Action operation);

    void CleanOperations();

    Task CommitChanges();
}