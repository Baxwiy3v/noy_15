using ConsoleApp7.DAL;
using ConsoleApp7.Models;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            
            StudentService service = new StudentService();


            service.Create(new Student { Name = "Aqil", Surname = "baxsiyev", AvgPoint = 4 });
            service.Create(new Student { Name = "ibo", Surname = "babazde", AvgPoint = 8 });
            service.Create(new Student { Name = "qarayev", Surname = "natiq", AvgPoint = 2 });


            List<Student> students = service.GetAll();
            Console.WriteLine("All students:");
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id} - {s.Name} {s.Surname} - {s.AvgPoint}");
            }

            Student student = service.GetById(2);
            Console.WriteLine("\nStudent by id:");
            Console.WriteLine($"{student.Id} - {student.Name} {student.Surname} - {student.AvgPoint}");


            service.Delete(3);


            students = service.GetAll();
            Console.WriteLine("\nAll students after deletion:");
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Id} - {s.Name} {s.Surname} - {s.AvgPoint}");
            }



        }
    }
    
}