using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Repositories;
using CleanArchitecture.Domian.Interfaces;
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
            #region ApplicationLayer
            service.AddScoped<ICourseService, CourseService>();
            #endregion

            #region Infra.DataLayer
            service.AddScoped<ICourseRepositoryService, CourseRepositoryService>();
            #endregion
        }
    }
}
