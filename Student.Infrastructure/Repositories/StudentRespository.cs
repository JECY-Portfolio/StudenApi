using Microsoft.EntityFrameworkCore;
using StudenApi.Data;
using Students.Application.Interfaces;

namespace Students.Infrastructure.Repositories
{
   public class StudentRespository : IStudentRepository
    {
        private readonly StudentDbContext dbContext;
        public StudentRespository(StudentDbContext studentDbContext)
        {
            dbContext = studentDbContext;
        }

        public async Task AddStudents(Domain.Entities.Student student)
        {
            await dbContext.AddAsync(student);
        }

        public async Task<List<Domain.Entities.Student>> GetAllStudents()
        {
          return  await dbContext.Students.ToListAsync(); 

        }

        //public async Task<Students> GetStudentsById(int id)
        //{
        //    var result = await dbContext.Students.Find(id);
        //    return result.ToList();

            
        //}
    }
}
