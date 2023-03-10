using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TraineeManagementApp.DAL.Enums;

namespace TraineeManagementApp.BLL.Models
{
    public class AddorUpdateTraineeVM
    {
        [Required, StringLength(50, ErrorMessage = "Character length allowed is between \"2 and 50\"", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required, StringLength(50, ErrorMessage = "Character length allowed is between \"2 and 50\"", MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "Character length allowed cannot be more than 50")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "Character length allowed cannot be more than 50")]
        public string Email { get; set; }

        [Required, StringLength(15, ErrorMessage = "Digits length cannot be more than 15")]
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
    }
}
