using System.ComponentModel.DataAnnotations;

using TraineeManagementApp.DAL.Entities;
using TraineeManagementApp.DAL.Enums;

namespace TraineeManagementApp.BLL.Models
{
    public class AddorUpdateResultVM
    {
        public decimal Score { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }
    }
}
