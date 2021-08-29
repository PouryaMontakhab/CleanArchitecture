﻿using CleanArchitecture.Application.ViewModels.CourseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetAll();
    }
}