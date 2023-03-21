﻿

namespace TraineeManagementSystem.DAL.Entities
{
    public class Trainee : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
