using Guide.Data.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Guide.Data.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        IMongoCollection<TEntity> Collection { get; }
        IMongoDatabase Database { get; }


        TEntity GetSingle(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(string Id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(string Id);
        IMongoQueryable<TEntity> Table { get; }

    }
}
