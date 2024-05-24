using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaR.Domain;

public interface IMongoContext
{
    IMongoCollection<T> GetCollection<T>(string name);
}

public class MongoDbContext : IMongoContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IConfiguration configuration)
    {
        var connection = configuration.GetConnectionString("Connection");
        var dataBase = configuration.GetConnectionString("DbName");
        var client = new MongoClient(connection);
        _database = client.GetDatabase(dataBase);
    }

    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _database.GetCollection<T>(name);
    }
}