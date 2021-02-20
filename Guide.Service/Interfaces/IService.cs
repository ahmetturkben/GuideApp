using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Guide.Service.Interfaces
{
    public interface IService<TEntity, BLEntity>
    {
        BLEntity GetSingle(Expression<Func<TEntity, bool>> predicate);
        BLEntity GetById(string Id);
        List<BLEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Add(BLEntity entity);
        void Update(BLEntity entity);
        void Remove(BLEntity entity);
    }
}
