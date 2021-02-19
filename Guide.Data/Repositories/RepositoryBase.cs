using Guide.Data.Entities;
using Guide.Data.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Guide.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        #region Fields

        /// <summary>
        /// Gets the collection
        /// </summary>
        protected IMongoCollection<T> _collection;
        public IMongoCollection<T> Collection
        {
            get
            {
                return _collection;
            }
        }

        /// <summary>
        /// Mongo Database
        /// </summary>
        protected IMongoDatabase _database;
        public IMongoDatabase Database
        {
            get
            {
                return _database;
            }
        }

        #endregion

        #region Ctor
        public RepositoryBase()
        {
            var client = new MongoClient("");
            var databaseName = new MongoUrl("").DatabaseName;
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }
        #endregion

        public void Add(T entity)
        {
            _collection.InsertOne(entity);
        }

        public T GetById(string Id)
        {
            return _collection.Find(e => e.Id == Id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _collection.ReplaceOne(x => x.Id == entity.Id, entity, new ReplaceOptions() { IsUpsert = false });
        }

        public void Delete(T entity)
        {
            _collection.FindOneAndDelete(e => e.Id == entity.Id);
        }

        public void Delete(string Id)
        {
            _collection.FindOneAndDelete(e => e.Id == Id);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual IMongoQueryable<T> Table
        {
            get { return _collection.AsQueryable(); }
        }
    }
}
