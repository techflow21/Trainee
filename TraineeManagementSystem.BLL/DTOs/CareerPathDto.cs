
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraineeManagementSystem.BLL.DTOs
{
    public class CareerPathDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IEnumerable<SelectListItem>? CareerPaths { get; set; }
    }
}
