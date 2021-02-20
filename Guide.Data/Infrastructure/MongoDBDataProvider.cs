using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Infrastructure
{
    public class MongoDBDataProvider : IDataProvider
    {
        public string ConnectionString => "mongodb+srv://guidapp_user:guidappuser@guidapp.wpzza.mongodb.net/guid_app?retryWrites=true&w=majority";
    }
}
