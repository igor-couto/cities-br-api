using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class BaseRepository<IEntity> : IRepository<IEntity>
    {
        private readonly MongoDbContext _context;

        public BaseRepository(MongoDbContext context) => _context = context; 

        public IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate)
        {
            return null;
        }

        public IEnumerable<IEntity> GetAll()
        {
            return null;
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
