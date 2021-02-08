using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CitiesBR.Infrastructure.Persistence.Database;
using CitiesBR.Domain.Interfaces;

namespace CitiesBR.Infrastructure.Presistence.Repository
{
    public class BaseRepository<IEntity> : IRepository<IEntity>
    {
        private readonly MongoDbContext _context;

        public BaseRepository(MongoDbContext context) => _context = context; 

        public IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEntity GetRamdon()
        {
            throw new NotImplementedException();
        }
    }
}
