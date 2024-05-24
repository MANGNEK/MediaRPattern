using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaR.Domain.GenericRepository;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T> GetById(int id);

    void Insert(T entity);

    void Update(string id, T entity);

    void Delete(int id);

    void Save();
}