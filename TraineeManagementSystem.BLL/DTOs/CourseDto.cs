
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.BLL.DTOs
{
    public class CourseDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Career Path")]
        public int? CareerPathId { get; set; }

        public CareerPathDto? CareerPath { get; set; }

        public IEnumerable<SelectListItem>? CareerPaths { get; set; }
    }
}
