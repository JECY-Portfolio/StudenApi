using Microsoft.AspNetCore.Mvc;
using StudenApi.DTOs;
using Student.Application.DTOs.Response;
using Students.Application.Interfaces;

namespace StudenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _studentService.GetStudentsAsync();

            return Ok(result);

        }
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] StudentCreateDTO studentCreateDTO)
        {
            await _studentService.AddStudentAsync(studentCreateDTO);
            return Created("", studentCreateDTO);
                
        }
       


        //[HttpGet("{id}")] 
        //public IActionResult GetById ([FromQuery] int id)
        //{
        // var DbContext =   

        //    if (DbContext == null)
        //        return NotFound();

        //    return Ok (DbContext);
        //}

    }
}
//    private readonly StudentDbContext _context;

//    public StudentController(StudentDbContext context)
//    {
//        _context = context;
//    }

//    [HttpGet]
//    public IActionResult GetAll()
//    {
//        var studentDTOs = _context.Students
//            .Select(s => new StudentGetDTO
//            {
//                FullName = s.FullName,
//                Email = s.Email,
//                Grade = s.Grade
//            }).ToList();

//        return Ok(studentDTOs);

//    }

//    [HttpGet("{id}")]
//    public IActionResult GetById(int id)
//    {
//        var student = _context.Students
//            .Find(id);

//            //.Where(s => s.Id == id)
//            //.Select(s => new StudentDTO
//            //{
//            //    FullName = s.FullName,
//            //    Email = s.Email,
//            //    Grade = s.Grade
//            //})
//            //.FirstOrDefault();

//        if (student == null)
//            return NotFound();

//            return Ok(student);

//    }

//    [HttpPost]
//    [ValidateModel]
//    public IActionResult Add(StudentCreateDTO studentDto)
//    {
//        var student = new Student
//        {
//            FullName = studentDto.FullName,
//            Age = studentDto.Age,
//            Email = studentDto.Email,
//            Grade = studentDto.Grade
//        };

//        _context.Students.Add(student);  // Add the new student to the context
//        _context.SaveChanges();          // Save changes to the database

//        return Ok(student);
//    }
//    [HttpPut("{id}")]
//    [ValidateModel]
//    public IActionResult Update(int id, StudentUpdateDTO studentDto)
//    {
//        var student = _context.Students.Find(id);  // Find student by id in the DB

//        if (student == null)
//            return NotFound();                      // Return 404 if not found

//        // Update properties
//        student.FullName = studentDto.FullName;
//        student.Age = studentDto.Age;
//        student.Email = studentDto.Email;
//        student.Grade = studentDto.Grade;

//        _context.SaveChanges();                      // Save changes to the DB

//        return Ok(student);                          // Return updated student
//    }
//    [HttpDelete("{id}")]
//    public IActionResult Delete(int id)
//    {
//        var student = _context.Students.Find(id);  // Find student by id

//        if (student == null)
//            return NotFound();                      // Return 404 if not found

//        _context.Students.Remove(student);          // Remove student from DB
//        _context.SaveChanges();                      // Commit deletion

//        return Ok("Student deleted successfully");
//    }



//}
//}
//        private static List<Student> students = new List<Student>();

//        [HttpGet]
//         public IActionResult GetAll()
//        {
//            return Ok(students);
//        }

//        [HttpPost]
//        public IActionResult Add(Student student)
//        {
//            students.Add(student);

//            return Ok(students);
//        }

//        [HttpPut("{id}")]
//        public IActionResult Update(int id, Student updatedStudent)

//        {
//            var student = students.FirstOrDefault(s => s.Id == id);
//            if (student == null)
//                return NotFound();

//            student.FullName = updatedStudent.FullName;
//            student.Age = updatedStudent.Age;
//            student.Email = updatedStudent.Email;
//            student.Grade = updatedStudent.Grade;

//            return Ok(student);

//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete (int id)
//        {
//            var student = students.FirstOrDefault(s => s.Id == id);
//            if (student == null)
//                return NotFound();

//            students.Remove(student);
//            return Ok("student deleted successfully");
//        }

//    }
//}
