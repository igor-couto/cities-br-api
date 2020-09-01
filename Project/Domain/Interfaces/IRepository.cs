using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<IEntity>
    {
        public IEnumerable<IEntity> Find(Expression<Func<IEntity, bool>> predicate);
        public IEnumerable<IEntity> GetAll();
        public IEntity Get(int id);
        public IEntity GetByName(string name);
        public IEntity GetRamdon();
    }
}
