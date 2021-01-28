using CqrsArch.Application.Interfaces;
using CqrsArch.Application.Services;
using CqrsArch.Domain.Interfaces;
using CqrsArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Infra.IoC
{
    public class DependencyBootstraper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
