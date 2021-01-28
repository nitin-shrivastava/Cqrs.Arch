using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cqrs.Arch.Domain.Core.Bus;
using CqrsArch.Application.Interfaces;
using CqrsArch.Application.ViewModel;
using CqrsArch.Domain.Commands;
using CqrsArch.Domain.Interfaces;
using System.Collections.Generic;

namespace CqrsArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
