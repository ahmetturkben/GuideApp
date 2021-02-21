using AutoMapper;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;
using Guide.Data.Repositories;
using Guide.Service.Infrastructure;
using Guide.Service.Interfaces;
using Guide.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuidApp.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IContactService, ContactService>();
            services.AddSingleton<IContactRepository, ContactRepository>();
            services.AddSingleton<IDataProvider, MongoDBDataProvider>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
