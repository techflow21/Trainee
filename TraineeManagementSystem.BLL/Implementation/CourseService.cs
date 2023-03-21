using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.BLL.Interfaces;
using TraineeManagementSystem.DAL.Entities;
using TraineeManagementSystem.DAL.Repository;

namespace TraineeManagementSystem.BLL.Implementation
{
    public class CourseService : ICourseService
    {
        private readonly TraineeDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseService(TraineeDbContext context, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var courseRepository = _unitOfWork.GetRepository<Course>();
            var courses = await courseRepository.GetAllAsync();
            var courseDtos = _mapper.Map<IEnumerable<CourseDto>>(courses);
            return courseDtos;
        }


        /*public async Task<CourseDto> GetCourseByIdAsync(int id)
        {
            var course = await _context.Courses
                .Include(c => c.CareerPath)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return null;
            }

            var courseDto = new CourseDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                CareerPathId = course.CareerPathId,
                CareerPath = new CareerPathDto
                {
                    Id = course.CareerPath.Id,
                    Name = course.CareerPath.Name
                }
            };

            return courseDto;
        }*/

        public async Task<CourseDto> GetCourseByIdAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            return _mapper.Map<CourseDto>(course);
        }

        public async Task AddCourseAsync(CourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCourseAsync(CourseDto courseDto)
        {

            var course = await _context.Courses.FindAsync(courseDto.Id);
            if (course != null)
            {
                _mapper.Map(courseDto, course);
                _context.Entry(course).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }


        public async Task DeleteCourseAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> CourseExists(int id)
        {
            return await _context.Courses.AnyAsync(e => e.Id == id);
        }
    }
}
