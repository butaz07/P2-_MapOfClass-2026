using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.Entities
{
    public class Employee: CommunityMember
    {
        public int EmployeeID { get; set; } 
        public string Position { get; set; }
        public decimal Salary { get; set; } 
        public DateTime HireDate { get; set; }
        public override void PrintInfo()
            {
            base.PrintInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: ${Salary}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
        }
    }
}
