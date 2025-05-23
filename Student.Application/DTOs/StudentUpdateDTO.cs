using System.ComponentModel.DataAnnotations;

namespace StudenApi.DTOs
{
    public class StudentUpdateDTO
    {
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Range(15, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Invalid Email format")]
        public string? Email { get; set; }
        public string? Grade { get; set; }
    }
}
