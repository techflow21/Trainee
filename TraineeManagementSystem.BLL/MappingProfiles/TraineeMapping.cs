using AutoMapper;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.MappingProfiles
{
    public class TraineeMapping : Profile
    {
        public TraineeMapping()
        {
            CreateMap<TraineeDto, Trainee>();
            CreateMap<Trainee, TraineeDto>();
        }
    }
}
