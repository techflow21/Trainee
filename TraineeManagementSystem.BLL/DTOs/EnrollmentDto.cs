
using TraineeManagementSystem.DAL.Enum;

namespace TraineeManagementSystem.BLL.DTOs
{
    public class EnrollmentDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public Grade? Grade { get; set; }
    }
}
