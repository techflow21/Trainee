using TraineeManagementSystem.BLL.DTOs;

namespace TraineeManagementSystem.BLL.Interfaces
{
    public interface IInstructorService
    {
        Task<IEnumerable<InstructorDto>> GetAllInstructorsAsync();
        Task<InstructorDto> GetInstructorByIdAsync(int id);
        Task AddInstructorAsync(InstructorDto instructorDto);
        Task UpdateInstructorAsync(InstructorDto instructorDto);
        Task DeleteInstructorAsync(int id);
        Task<bool> InstructorExists(int id);

        /*Task<IEnumerable<Instructor>> GetAllInstructorsAsync();
        Task<Instructor> GetInstructorByIdAsync(int id);
        Task AddInstructorAsync(Instructor instructor);
        Task UpdateInstructorAsync(Instructor instructor);
        Task DeleteInstructorAsync(Instructor instructor);*/

    }
}
