using System.Collections.Generic;
using CitiesBR.Domain.Entities;

namespace CitiesBR.Domain.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        public IEnumerable<City> GetMostPopulousCity();
    }
}