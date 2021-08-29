using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels.CourseViewModels
{
    public class CourseViewModel
    {
        IEnumerable<Course> Courses { get; set; }
    }
}
