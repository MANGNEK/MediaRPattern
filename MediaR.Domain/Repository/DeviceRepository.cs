using Mapster;
using MediaR.Domain.IRepository;
using MediaR.Domain.Models;
using MediaR.Domain.Ufw;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace MediaR.Domain.Repository;

public class DeviceRepository
{
    //private readonly IMongoDatabase _database;
    private readonly IMongoCollection<Device> _deviceContext;

    private readonly IUnitOfWork _unitOfWork;

    public DeviceRepository(IUnitOfWork unitOfWork, IMongoContext mongoContext)
    {
        _unitOfWork = unitOfWork;
        this._deviceContext = mongoContext.GetCollection<Device>("Device");
    }
}