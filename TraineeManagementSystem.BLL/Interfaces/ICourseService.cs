
using TraineeManagementSystem.BLL.DTOs;

namespace TraineeManagementSystem.BLL.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto> GetCourseByIdAsync(int id);
        Task AddCourseAsync(CourseDto courseDto);
        Task UpdateCourseAsync(CourseDto courseDto);
        Task DeleteCourseAsync(int id);
        Task<bool> CourseExists(int id);
    }
}
