using CqrsArch.Domain.Interfaces;
using CqrsArch.Domain.Models;
using CqrsArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Infra.Data.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext context)
        {
            _ctx = context;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
           return _ctx.Courses;
        }
    }
}
