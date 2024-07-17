using StudentManagement.Shared.Models;
using StudentManagement.Shared.StudentRepository;
using System.Net.Http.Json;

namespace StudentManagement.Client.Services
{
    public class StudentService : IStudentRepository
    {
        private readonly HttpClient _httpClient;
        public StudentService(HttpClient _httpClient) 
        {
            this._httpClient = _httpClient;
        
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Student/Add-Student", student);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Student>();
        }


        public Task<Student> DeleteStudentAsync(int student)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Student/All-Students");
            var response = await allstudent.Content.ReadFromJsonAsync<List<Student>>();
            return response;
        }

        public async Task<Student> GetAllStudentsByIdAsync(int studentId)
        {
            var singlestudent = await _httpClient.GetAsync("api/Student/Single-Student");
            var response = await singlestudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public  async Task<Student> UpdateStudentAsync(Student student)
        {
            var updatestudent = await _httpClient.PostAsJsonAsync("api/Student/Update-Student", student);
            var response = await updatestudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }
    }
}  
