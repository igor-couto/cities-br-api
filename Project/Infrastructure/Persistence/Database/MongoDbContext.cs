using CitiesBR.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CitiesBR.Infrastructure.Persistence.Database
{
    public class MongoDbContext : IDbContext
    {
        private readonly IMongoDatabase _db;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString"));
            _db = client.GetDatabase(configuration.GetSection("DatabaseSettings").GetValue<string>("DatabaseName"));
        }

        public IMongoCollection<City> Cities 
            => _db.GetCollection<City>("Cities");
    }
}