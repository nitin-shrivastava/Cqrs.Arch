using AutoMapper;
using CqrsArch.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CqrsArch.Application.Mapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
