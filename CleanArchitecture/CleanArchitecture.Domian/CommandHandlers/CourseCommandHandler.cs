using CleanArchitecture.Domian.Commands;
using CleanArchitecture.Domian.Interfaces;
using CleanArchitecture.Domian.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domian.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepositoryService _courseRepository;

        public CourseCommandHandler(ICourseRepositoryService courseRepository )
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };
            _courseRepository.Add(course);


            return Task.FromResult(true);
            
        }
    }
}
