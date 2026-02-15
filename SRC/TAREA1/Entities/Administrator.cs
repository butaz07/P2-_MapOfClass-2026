using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.Entities
{
    public class Administrator: Employee
    {
        public string DepartmentManaged { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo(); 
            Console.WriteLine($"Department Managed: {DepartmentManaged}");
        }
    }
}
