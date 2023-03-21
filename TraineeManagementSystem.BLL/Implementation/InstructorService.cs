using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TraineeManagementSystem.BLL.DTOs;
using TraineeManagementSystem.BLL.Interfaces;
using TraineeManagementSystem.DAL.Entities;
using TraineeManagementSystem.DAL.Repository;

namespace TraineeManagementSystem.BLL.Implementation
{
    public class InstructorService : IInstructorService
    {
        private readonly TraineeDbContext _context;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InstructorService(IUnitOfWork unitOfWork, TraineeDbContext context, IMapper mapper)
        {
            /*_unitOfWork = unitOfWork;*/
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstructorDto>> GetAllInstructorsAsync()
        {
            var instructors = await _context.Instructors.ToListAsync();
            return _mapper.Map<IEnumerable<InstructorDto>>(instructors);
        }

        public async Task<InstructorDto> GetInstructorByIdAsync(int id)
        {
            var instructor = await _context.Instructors.FindAsync(id);
            return _mapper.Map<InstructorDto>(instructor);
        }

        public async Task AddInstructorAsync(InstructorDto instructorDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorDto);
            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateInstructorAsync(InstructorDto instructorDto)
        {
            var instructor = await _context.Instructors.FindAsync(instructorDto.Id);
            if (instructor != null)
            {
                _mapper.Map(instructorDto, instructor);
                _context.Entry(instructor).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteInstructorAsync(int id)
        {
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> InstructorExists(int id)
        {
            var instructor = await GetInstructorByIdAsync(id);
            return instructor != null;
        }
    }
}
