
namespace TraineeManagementSystem.DAL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        //public int? CareerPathId { get; set; }
        public virtual CareerPath? CareerPath { get; set; }
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
