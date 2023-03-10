
namespace TraineeManagementApp.DAL.Entities
{
    public class Admin : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Trainee> Trainees { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
