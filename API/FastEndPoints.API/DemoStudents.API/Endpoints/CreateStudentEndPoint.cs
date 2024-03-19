using DemoStudents.API.DTO.Requests;
using DemoStudents.API.DTO.Responses;
using DemoStudents.API.Models;
using FastEndpoints;

namespace DemoStudents.API.Endpoints
{
    public class CreateStudentEndPoint : Endpoint<CreateStudentRequest, CreateStudentResponse>
    {
        public override void Configure()
        {
            Post("/students");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateStudentRequest request, CancellationToken ct)
        {
            var idResult = Student.CreateStudent(request.Name, request.Promotion);

            await SendAsync(new CreateStudentResponse { Id = idResult });
        }
    }
}
