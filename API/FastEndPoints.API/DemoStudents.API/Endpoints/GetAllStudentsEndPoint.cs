using DemoStudents.API.Models;
using FastEndpoints;
using System.Xml.Linq;

namespace DemoStudents.API.Endpoints
{
    public class GetAllStudentsEndPoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("/students");
            AllowAnonymous(); // Ici dans la réalité on vérifie le rôle de l'utilisateur
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Cyril", Promotion = new Promotion {Name="CDA" } },
                new Student { Id = 2, Name = "Jessica", Promotion = new Promotion {Name="CDA" } },
                new Student { Id = 3, Name = "Mathias", Promotion = new Promotion {Name="CDA" } }
            };

            await SendAsync(students);
        }
    }
}
