using Microsoft.EntityFrameworkCore;

namespace StudenApi.Data
{

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {        
        }

        public DbSet<Domain.Entities.Student> Students { get; set; }
    } 
}