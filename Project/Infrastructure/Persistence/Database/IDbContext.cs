using CitiesBR.Domain.Entities;
using MongoDB.Driver;

namespace CitiesBR.Infrastructure.Persistence.Database
{
    public interface IDbContext
    {
        IMongoCollection<City> Cities { get; }
    }
}