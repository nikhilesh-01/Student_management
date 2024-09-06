using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Shared.Models;
using StudentManagement.Shared.StudentRepository;

namespace StudentManagement.Services
{
    public class StudentsRepositoy : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        //constructor creation
        public StudentsRepositoy(ApplicationDbContext context) 
        {
            this._context = context;              
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            if(student == null) throw new ArgumentNullException();  
            var newstudent  = _context.Students.Add(student).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }


        public async Task<Student?>  DeleteStudentAsync(int studentId)
        {
            var delstudent = await _context.Students.Where(x => x.Id == studentId).FirstOrDefaultAsync();
            if (delstudent == null)
            {
                _context.Students.Remove(delstudent);
                await _context.SaveChangesAsync();
            }
            return delstudent;
 
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await _context.Students.ToListAsync();

            return students;
        }

        public async Task<Student?> GetAllStudentsByIdAsync(int studentId)
        {
            var singlestudent = await _context.Students.Where(x => x.Id == studentId).FirstOrDefaultAsync();
            if (singlestudent == null) return null;

            return singlestudent;
        } 


        public async Task<Student?> UpdateStudentAsync(Student student)
        {
            if (student == null) return null;


            var newstudent = _context.Students.Update(student).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }
    }
}
