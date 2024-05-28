using MediaR.Domain.GenericRepository;
using MediaR.Domain.Models;

namespace MediaR.Domain.IRepository;

public interface IDevice
{
    Task<IEnumerable<DeviceModel>> GetAllAsync();

    Task<DeviceModel> GetById(string id);

    void Insert(DeviceModel entity);

    void Update(string id, DeviceModel entity);

    void Delete(string id);

    void Save();
}