using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudenApi.DTOs;
using Student.Application.DTOs.Response;

namespace Students.Application.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentResponse>> GetStudentsAsync();

        Task<StudentResponse> AddStudentAsync(StudentCreateDTO studentCreateDTO);

    }
}
