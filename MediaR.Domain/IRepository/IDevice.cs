using MediaR.Domain.GenericRepository;
using MediaR.Domain.Models;

namespace MediaR.Domain.IRepository;

public interface IDevice
{
    Task<IEnumerable<DeviceModel>> GetAllAsync();

    Task<DeviceModel> GetById(int id);

    void Insert(DeviceModel entity);

    void Update(string id, DeviceModel entity);

    void Delete(int id);

    void Save();
}