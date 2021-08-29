using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels.CourseViewModels;
using CleanArchitecture.Domian.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepositoryService _courseRepositoryService;

        public CourseService(ICourseRepositoryService courseRepositoryService)
        {
            _courseRepositoryService = courseRepositoryService;
        }
        public CourseViewModel GetAll()
        {
            return new CourseViewModel
            {
                Courses = _courseRepositoryService.GetAll()
            };
        }
    }
}
