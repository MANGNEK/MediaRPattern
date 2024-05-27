using Mapster;
using MediaR.Domain.GenericRepository;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediaR.Domain.Ufw;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace MediaR.Domain.Repository;

public class DeviceRepository(IUnitOfWork unitOfWork, IMongoContext collection) : GenericRepository<DeviceModel>(unitOfWork, collection), IDevice
{
    //private readonly IMongoDatabase _database;
    private readonly IMongoCollection<DeviceModel> _deviceContext;

    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<DeviceModel> repository;
}