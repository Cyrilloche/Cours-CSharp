using DemoStudents.API.DTO.Requests;
using DemoStudents.API.DTO.Responses;
using DemoStudents.API.Models;
using FastEndpoints;

namespace DemoStudents.API.Endpoints
{
    public class DeleteStudentByIdEndPoint : Endpoint<DeleteStudentRequest>
    {
        public override void Configure()
        {
            Delete("/students/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DeleteStudentRequest request, CancellationToken ct)
        {
            var result = Student.DeleteStudent(request.Id);

            await SendAsync(new DeleteStudentResponse { IsDeleted = result });
        }
    }
}
