using DemoStudents.API.DTO.Requests;
using DemoStudents.API.Models;
using FastEndpoints;

namespace DemoStudents.API.Endpoints
{
    public class GetStudentByIdEndPoint : Endpoint<GetStudentByIdRequest>
    {
        public override void Configure()
        {
            Get("/students/{id}");
            AllowAnonymous();
        }


        public override async Task HandleAsync(GetStudentByIdRequest request, CancellationToken ct)
        {
            var student = Student.GetStudentById(request.Id);

            await SendAsync(student);
        }
    }
}
