using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class CityRepository : ICityRepository
    {
        public IEnumerable<City> Find(Expression<Func<City, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public City Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetMostPopulousCity()
        {
            throw new NotImplementedException();
        }

        public City GetRamdon()
        {
            throw new NotImplementedException();
        }
    }
}