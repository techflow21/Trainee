
namespace TraineeManagementApp.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime EnrolledDate { get; set; } = DateTime.Now;
    }
}
