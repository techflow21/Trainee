using AutoMapper;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.MappingProfiles
{
    public class CareerPathMapping : Profile
    {
        public CareerPathMapping()
        {
            CreateMap<CareerPathDto, CareerPath>();
            CreateMap<CareerPath, CareerPathDto>();
        }
    }
}
