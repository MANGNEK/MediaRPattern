using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace MediaR.Domain.Ufw;

public class UnitOfWork : IUnitOfWork
{
    private IClientSessionHandle sessionHandle { get; }
    IDisposable IUnitOfWork.Session => sessionHandle;
    private List<Action> _operations { get; set; }

    public UnitOfWork(IConfiguration configuration)
    {
        var mongoClient = new MongoClient(configuration.GetConnectionString("Connection"));
        sessionHandle = mongoClient.StartSession();
        _operations = new List<Action>();
    }

    public void AddOperation(Action operation)
    {
        _operations.Add(operation);
    }

    public void CleanOperations()
    {
        _operations.Clear();
    }

    public async Task CommitChanges()
    {
        sessionHandle.StartTransaction();
        _operations.ForEach(o =>
        {
            o.Invoke();
        });
        await sessionHandle.CommitTransactionAsync();
        GC.SuppressFinalize(this);
    }
}