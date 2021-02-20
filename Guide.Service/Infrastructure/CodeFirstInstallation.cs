using MongoDB.Driver;
using System;
using Microsoft.Extensions.DependencyInjection;
using Guide.Data.Infrastructure;
using System.Linq;
using Guide.Data.Entities;
using MongoDB.Bson;

namespace Guide.Service.Infrastructure
{
    public class CodeFirstInstallation : ICodeFirstInstallation
    {
        private readonly IServiceProvider _serviceProvider;
        public CodeFirstInstallation(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateTables(string local, string connectionString)
        {
            if (string.IsNullOrEmpty(local))
                local = "en";

            try
            {
                var options = new CreateCollectionOptions();
                var collation = new Collation(local);
                options.Collation = collation;

                var mongourl = new MongoUrl(connectionString);
                var databaseName = mongourl.DatabaseName;
                var mongodb = new MongoClient(connectionString).GetDatabase(databaseName);
                var mongoDBContext = new MongoDBContext(mongodb);

                //var contactType = Type.GetType("Guide.Data.Entities.Contact, Guide.Data");
                var assembLoad = System.Reflection.Assembly.Load("Guide.Data");
                foreach (var item in assembLoad.GetTypes())
                {
                    if (item.BaseType != null && item.IsClass && item.BaseType == typeof(BaseEntity))
                    {
                        var filter = new BsonDocument("name", item.Name.ToString());
                        if (!mongoDBContext.Database().ListCollections(new ListCollectionsOptions { Filter = filter }).Any())
                            mongoDBContext.Database().CreateCollection(item.Name, options);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
