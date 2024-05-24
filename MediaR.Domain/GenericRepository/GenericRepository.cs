using MediaR.Domain.Ufw;
using MongoDB.Driver;

namespace MediaR.Domain.GenericRepository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMongoCollection<T> _context;

    public GenericRepository(IUnitOfWork unitOfWork, IMongoContext mongoContext)
    {
        _unitOfWork = unitOfWork;
        _context = mongoContext.GetCollection<T>(typeof(T).Name.ToString());
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var result = await _context.FindAsync(_ => true);
        return await result.ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        var filter = Builders<T>.Filter.Eq("Id", id);
        var result = await _context.FindAsync(filter);
        return await result.FirstOrDefaultAsync();
    }

    public void Insert(T entity)
    {
        Action action = () => this._context.InsertOne(this._unitOfWork.Session as IClientSessionHandle, entity);
        this._unitOfWork.AddOperation(action);
    }

    public void Update(string id, T entity)
    {
        Action action = () =>
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            this._context.ReplaceOne(this._unitOfWork.Session as IClientSessionHandle, filter, entity);
        };
        this._unitOfWork.AddOperation(action);
    }

    public void Delete(int id)
    {
        Action action = () =>
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            this._context.DeleteOne(this._unitOfWork.Session as IClientSessionHandle, filter);
        };
        this._unitOfWork.AddOperation(action);
    }

    public void Save()
    {
        _unitOfWork.CommitChanges();
    }
}