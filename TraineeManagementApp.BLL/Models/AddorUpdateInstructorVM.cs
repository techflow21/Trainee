using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeManagementApp.BLL.Models
{
    public class AddorUpdateInstructorVM
    {
        [Required, StringLength(50, ErrorMessage = "Character length allowed is between \"2 and 50\"", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required, StringLength(50, ErrorMessage = "Character length allowed is between \"2 and 50\"", MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "Character length allowed cannot be more than 50")]
        public string Email { get; set; }

        [Required, StringLength(15, ErrorMessage = "Digits length cannot be more than 15")]
        public string PhoneNumber { get; set; }
    }
}
