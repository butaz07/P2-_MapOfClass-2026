//ESTA ES MI VERSION DEL DIAGRAMA DE CLASES APLICANDO POO 
//IAN ELIAN CHAVEZ FRANCO 
//20242577
//PROGRAMACION 2







using TAREA1.Entities;
namespace TAREA1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var members = new List<Entities.CommunityMember>();

            

            members.Add(new Entities.Teacher
            {
                Name = "FRANCIA",
                Age = 50,
                Email = "francia@school.com",
                Salary = 60000,         
                MainSubject = "Chemistry", 
                EmployeeID =015
            });

           
            members.Add(new Entities.Administrator
            {
                Name = "Liopo",
                Age = 60,
                Email = "liopo@school.com",
                Salary = 85000,          
                Position = "Principal",  
                DepartmentManaged = "General Direction",
                 EmployeeID = 016
            });

           
            members.Add(new Entities.Employee
            {
                Name = "Rodolfo",
                Age = 45,
                Position = "Groundskeeper",
                Salary = 30000,
                 EmployeeID = 018
            });

            members.Add(new Entities.Student
            {
                Name = "Alicia",
                Age = 20,
                studentID = 12345,
                average = 3.5,
                carrier = "Computer Science" 
            });


            

            foreach (var person in members)
            {
                
                person.PrintInfo();
                Console.WriteLine("-----------------------------");
            }

           
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
