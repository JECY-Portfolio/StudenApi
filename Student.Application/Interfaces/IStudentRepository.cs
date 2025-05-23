using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudenApi.DTOs;

namespace Students.Application.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Domain.Entities.Student>> GetAllStudents();

        Task AddStudents(Domain.Entities.Student student);


        //  Task<Students> GetStudentsById(int id);
    }
}
