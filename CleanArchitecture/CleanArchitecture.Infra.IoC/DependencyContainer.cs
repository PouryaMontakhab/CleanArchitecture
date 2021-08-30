using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Data.Repositories;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domian.CommandHandlers;
using CleanArchitecture.Domian.Commands;
using CleanArchitecture.Domian.Interfaces;
using CleanArchitecture.Infra.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            #region MediatR
            service.AddScoped<IMediatorHandler, InMemoryBus>();
            #endregion

            #region DomainHandler
            service.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            #endregion

            #region ApplicationLayer
            service.AddScoped<ICourseService, CourseService>();
            #endregion

            #region Infra.DataLayer
            service.AddScoped<ICourseRepositoryService, CourseRepositoryService>();
            service.AddScoped<UniversityDbContext>();
            #endregion
        }
    }
}
