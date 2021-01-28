using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CqrsArch.Application.Interfaces;
using CqrsArch.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CqrsArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }
    }
}
