using System.ComponentModel.DataAnnotations;

namespace StudenApi.DTOs
{
    public class StudentGetDTO
    {
        
        public string FullName { get; set; }

        public string Email { get; set; }
        
        public string? Grade { get; set; }
    }
}
