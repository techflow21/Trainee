using System.ComponentModel.DataAnnotations;

namespace TraineeManagementApp.BLL.Models
{
    public class AddorUpdateCourseVM
    {
        [Required, StringLength(50, ErrorMessage = "Character length allowed is between \"3 and 1000\"", MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(1000, ErrorMessage = "Character length allowed is between \"3 and 1000\"", MinimumLength = 3)]
        public string Description { get; set; }
    }
}
