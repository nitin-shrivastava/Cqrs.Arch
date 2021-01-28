using Cqrs.Arch.Domain.Core.Bus;
using Cqrs.Arch.Infra.ServiceBus;
using CqrsArch.Application.Interfaces;
using CqrsArch.Application.Services;
using CqrsArch.Domain.CommandHandlers;
using CqrsArch.Domain.Commands;
using CqrsArch.Domain.Interfaces;
using CqrsArch.Infra.Data.Context;
using CqrsArch.Infra.Data.Repository;
using MediatR;
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
        {//Domain InMemory
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();
        }
    }
}
