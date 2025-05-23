using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using StudenApi.DTOs;
using Student.Application.DTOs.Response;
using Students.Application.Interfaces;

namespace Student.Application.Implementations
{
   public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentResponse> AddStudentAsync(StudentCreateDTO studentCreateDTO)
        {
          var addStudent =  _mapper.Map<Domain.Entities.Student>(studentCreateDTO);
            await _studentRepository.AddStudents(addStudent);
            var response = _mapper.Map<StudentResponse>(addStudent);
            return response;
        }

        public async Task<List<StudentResponse>> GetStudentsAsync()
        {
       var result= await _studentRepository.GetAllStudents();

            var students = result.Select(s => new StudentResponse
            {
                Id = s.Id,
                FullName = s.FullName,
                Age = s.Age,
                Grade= s.Grade,
                Email= s.Email
            }).ToList();

            return students;





        }
    }
}
