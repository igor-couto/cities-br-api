using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        public IEnumerable<City> GetMostPopulousCity();
    }
}