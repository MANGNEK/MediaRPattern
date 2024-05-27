using MediaR.Domain.IRepository;
using MediaR.Domain.Repository;
using MediaR.Domain.Ufw;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediaR.Domain.ConfigDb;

public static class DIConfig
{
    public static void AddDomain(this IServiceCollection service, IConfiguration confiuration)
    {
        //var connection = confiuration.GetConnectionString("Connection") ?? "";
        //var dataName = confiuration.GetConnectionString("DbName") ?? "";
        //service.AddScoped<IMongoContext>(e =>
        //{
        //    return new MongoDbContext(connection, dataName);
        //});
        //service.AddScoped<IMongoContext, MongoDbContext>();
        service.AddScoped<IDevice, DeviceRepository>();
        service.AddScoped<IUnitOfWork, UnitOfWork>();
        service.AddScoped<IMongoContext, MongoDbContext>();
    }
}