namespace TraineeManagementApp.DAL.Entities
{
    public class Instructor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Trainee> Trainees { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
