using DemoStudents.API.Models;

namespace DemoStudents.API.DTO.Requests
{
    public class CreateStudentRequest
    {
        public string Name { get; set; }
        public Promotion Promotion { get; set; }
    }
}
