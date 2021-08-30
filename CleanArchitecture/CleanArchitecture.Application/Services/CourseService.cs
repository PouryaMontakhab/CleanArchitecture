using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels.CourseViewModels;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domian.Commands;
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
        private readonly IMediatorHandler _mediatorHandler;

        public CourseService(ICourseRepositoryService courseRepositoryService,IMediatorHandler mediatorHandler)
        {
            _courseRepositoryService = courseRepositoryService;
            _mediatorHandler = mediatorHandler;
        }

        public void CreteCourse(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            _mediatorHandler.SendCommand(createCourseCommand);
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
