﻿
using Microsoft.EntityFrameworkCore;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.Interfaces
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync();
        Task<Enrollment> GetEnrollmentByIdAsync(int id);
        Task AddEnrollmentAsync(Enrollment enrollment);
        Task UpdateEnrollmentAsync(Enrollment enrollment);
        Task DeleteEnrollmentAsync(Enrollment enrollment);
        //Task<Enrollment> GetByIdAsync(int id, Func<IQueryable<Enrollment>, IQueryable<Enrollment>> include = null);

    }
}
