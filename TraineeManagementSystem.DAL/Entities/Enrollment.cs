using System.ComponentModel.DataAnnotations;
using TraineeManagementSystem.DAL.Enum;

namespace TraineeManagementSystem.DAL.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TraineeId { get; set; }

        //[DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}