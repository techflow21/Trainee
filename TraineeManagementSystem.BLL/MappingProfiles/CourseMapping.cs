using AutoMapper;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.MappingProfiles
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<CourseDto, Course>();
            CreateMap<Course, CourseDto>();
        }
    }
}
