using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Infrastructure
{
    public class MongoDBContext : IMongoDBContext
    {
        protected IMongoDatabase _database;
        public MongoDBContext()
        {

        }
        public MongoDBContext(IMongoDatabase mongodatabase)
        {
            _database = mongodatabase;
        }

        public IMongoDatabase Database()
        {
            return _database;
        }

        public TResult RunCommand<TResult>(string command)
        {
            return _database.RunCommand<TResult>(command);
        }

        public TResult RunCommand<TResult>(string command, ReadPreference readpreference)
        {
            return _database.RunCommand<TResult>(command, readpreference);
        }
    }
}
