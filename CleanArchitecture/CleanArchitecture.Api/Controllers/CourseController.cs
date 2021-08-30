using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels.CourseViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post(CourseViewModel courseViewModel)
        {
            _courseService.CreteCourse(courseViewModel);
            return Ok(courseViewModel);
        }
    }
}
