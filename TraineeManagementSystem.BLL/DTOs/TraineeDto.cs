using System.ComponentModel.DataAnnotations;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.DTOs
{
    /*public class TraineeDto
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters.")]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }*/


    public class TraineeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        [StringLength(50, ErrorMessage = "The Last Name field cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        [StringLength(50, ErrorMessage = "The First Name field cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Address field is required.")]
        [StringLength(500, ErrorMessage = "The Address field cannot exceed 500 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Phone Number field is required.")]
        [StringLength(20, ErrorMessage = "The Phone Number field cannot exceed 20 characters.")]
        public string PhoneNumber { get; set; }
    }

}
