
using AutoMapper;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.MappingProfiles
{
    public class InstructorMapping : Profile
    {
        public InstructorMapping()
        {
            CreateMap<InstructorDto, Instructor>();
            CreateMap<Instructor, InstructorDto>();
        }
    }
}
