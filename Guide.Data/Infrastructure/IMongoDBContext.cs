using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Infrastructure
{
    public interface IMongoDBContext
    {
        IMongoDatabase Database();
        TResult RunCommand<TResult>(string command);
        TResult RunCommand<TResult>(string command, ReadPreference readpreference);
    }
}
