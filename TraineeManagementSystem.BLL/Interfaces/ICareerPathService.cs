
using Microsoft.EntityFrameworkCore;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.Interfaces
{
    public interface ICareerPathService
    {
        Task<IEnumerable<CareerPathDto>> GetAllCareerPathsAsync();
        Task<CareerPathDto> GetCareerPathByIdAsync(int id);
        Task AddCareerPathAsync(CareerPathDto careerDto);
        Task UpdateCareerPathAsync(CareerPathDto careerDto);
        Task DeleteCareerPathAsync(int id);
        Task<bool> CareerPathExists(int id);
    }
}
