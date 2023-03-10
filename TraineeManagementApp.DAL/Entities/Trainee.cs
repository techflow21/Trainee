
using TraineeManagementApp.DAL.Enums;

namespace TraineeManagementApp.DAL.Entities
{
    public class Trainee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Gender? Gender { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
