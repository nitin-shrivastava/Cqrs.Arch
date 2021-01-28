using CqrsArch.Application.Interfaces;
using CqrsArch.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cqrs.Arch.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseService courseService,ILogger<CourseController> logger)
        {
            _logger = logger;
            _courseService = courseService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);
            return Ok();
        }

       
    }
}
