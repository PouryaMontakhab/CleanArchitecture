using CleanArchitecture.Data.Context;
using CleanArchitecture.Domian.Interfaces;
using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Data.Repositories
{
    public class CourseRepositoryService : ICourseRepositoryService
    {
        private readonly UniversityDbContext _context;

        public CourseRepositoryService(UniversityDbContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses;
        }
    }
}
