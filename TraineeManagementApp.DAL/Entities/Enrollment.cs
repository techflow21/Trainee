using TraineeManagementApp.DAL.Enums;

namespace TraineeManagementApp.DAL.Entities
{
    public class Enrollment : BaseEntity
    {
        //public int CourseId { get; set; }
        //public int InstructorId { get; set; }
        //public int TraineeId { get; set; }
        //public Course Course { get; set; }
        //public Instructor Instructor { get; set; }
        //public Trainee Trainee { get; set; }
        public Grade? Grade { get; set; }
        public decimal? Score { get; set; }
    }
}
