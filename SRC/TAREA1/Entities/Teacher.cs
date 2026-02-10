using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.Entities
{
    public class Teacher : Employee
    {
        public string TeacherID { get; set; } 
        public string MainSubject { get; set; }
        
            public override void PrintInfo()
            {
                base.PrintInfo(); 
                Console.WriteLine($"Teacher ID: {TeacherID}");
                Console.WriteLine($"Main Subject: {MainSubject}");
        }

    }
}
