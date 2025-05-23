using System.ComponentModel.DataAnnotations;

namespace StudenApi.DTOs
{
    public class StudentCreateDTO
    {
        [Required(ErrorMessage = "Full name is required")]
        [MinLength(5, ErrorMessage = "Full name must be atleast 5 characters")]
        public string FullName { get; set; }

        [Range(15,100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
        public string? Grade { get; set; }
    }
}
