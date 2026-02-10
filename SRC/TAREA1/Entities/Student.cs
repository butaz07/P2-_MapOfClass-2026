using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.Entities
{
    public class Student:CommunityMember 
    {
        public int studentID { get; set; }
        public double average { get; set; }
       
       
        public string carrier { get; set; }
        public override void PrintInfo()
            {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Average Grade: {average}");
            Console.WriteLine($"Carrier: {carrier}");
        }
    }
   
}
