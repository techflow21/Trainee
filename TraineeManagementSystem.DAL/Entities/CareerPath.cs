using System.ComponentModel.DataAnnotations;


namespace TraineeManagementSystem.DAL.Entities
{
    public class CareerPath
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
