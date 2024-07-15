using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Shared.Models;
using StudentsManagement.Shared.StudentRepository;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;

        //constructor
        public StudentController(IStudentRepository studentRepository)
        {

            this._studentRepository = studentRepository;
        }
        //Get all students 
        [HttpGet("All-Students")]
        public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
        {
            var student = await _studentRepository.GetAllStudentsAsync();

            return Ok(student);
        }

        //get student info with there ID's
        [HttpGet("Single-Student/{id}")]
        public async Task<ActionResult<List<Student>>> GetSingleStudentsAsync(int id)
        {
            var student = await _studentRepository.GetAllStudentsByIdAsync(id);

            return Ok(student);
        }

            //Add student 
            [HttpGet("Add-Students/{id}")]
            public async Task<ActionResult<List<Student>>> AddStudentAsync(Student student)
            {
                var newstudent = await _studentRepository.AddStudentAsync(student);

                return Ok(newstudent);
            }

        //Delete student
        [HttpGet("Delete-Student/{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _studentRepository.DeleteStudentAsync(id);

            return Ok(deletestudent);
        }
    }
}