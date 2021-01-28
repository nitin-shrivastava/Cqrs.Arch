using AutoMapper;
using CqrsArch.Application.ViewModel;
using CqrsArch.Domain.Commands;
using CqrsArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsArch.Application.Mapper
{
    public class UniversityProfiles:Profile
    {
        public UniversityProfiles()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
            CreateMap<Course, CourseViewModel>();
        }
    }
}
