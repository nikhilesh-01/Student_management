using System.ComponentModel.DataAnnotations;
namespace StudentManagement.Shared.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }

        public required string EmailAddress { get; set; }

        public required string Address { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Country { get; set; }
    }
}
