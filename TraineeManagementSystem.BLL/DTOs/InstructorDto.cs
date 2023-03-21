
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.DTOs
{
    /*public class InstructorDto
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

        public ICollection<CourseDto> Courses { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
*/
    public class InstructorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the instructor's first name.")]
        [StringLength(50, ErrorMessage = "The first name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the instructor's last name.")]
        [StringLength(50, ErrorMessage = "The last name cannot exceed 50 characters.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter the instructor's last name.")]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "The last name cannot exceed 50 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the instructor's last name.")]
        [StringLength(50, ErrorMessage = "The last name cannot exceed 50 characters.")]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RegisteredDate { get; set; }

        [Display(Name = "Available Courses")]
        public int? SelectedCourseId { get; set; }

        public CourseDto? Course { get; set; }

        public IEnumerable<SelectListItem>? Courses { get; set; }

    }
}
