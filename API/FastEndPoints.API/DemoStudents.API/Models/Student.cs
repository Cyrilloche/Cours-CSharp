namespace DemoStudents.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Promotion Promotion { get; set; }

        public static Student GetStudentById(int id)
        {
            // A la place de la base de donnée on crée un Student 
            return new Student { Id = id, Name = "Cédric", Promotion = new Promotion { Name = "CDA" } };
        }

        public static int CreateStudent(string name, Promotion promotion)
        {
            Console.WriteLine("Nom " + name + "\nPromotion : " + promotion.Name);
            // A la place de la requête en BDD
            // Le student devrait être créer en BDD
            return 1;
        }

        public static bool DeleteStudent(int id)
        {
            Console.WriteLine("Deleting student with id {0}", id);
            return true;
        }
    }
}
