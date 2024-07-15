using StudentManagement.Shared.Models;
using StudentsManagement.Shared.StudentRepository;

namespace StudentManagement.Client.Services
{
    public class StudentService : IStudentRepository
    {

        public  StudentService() { }

        public Task<Student> AddStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<Student> DeleteStudentAsync(int student)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetAllStudentsByIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}  
