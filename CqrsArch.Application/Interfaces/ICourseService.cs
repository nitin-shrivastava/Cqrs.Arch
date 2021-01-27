using CqrsArch.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsArch.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
