using StudentManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared.StudentRepository
{
    public interface IStudentRepository
    {
     Task<Student> AddStudentAsync(Student student);

     Task<Student> UpdateStudentAsync(Student student);

     Task<Student> DeleteStudentAsync(int student);

     Task<List<Student>> GetAllStudentsAsync();

     Task<Student> GetAllStudentsByIdAsync(int studentId);

    }
}
