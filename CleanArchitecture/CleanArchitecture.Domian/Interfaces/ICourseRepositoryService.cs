using CleanArchitecture.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domian.Interfaces
{
    public interface ICourseRepositoryService
    {
        IEnumerable<Course> GetAll();
    }
}
