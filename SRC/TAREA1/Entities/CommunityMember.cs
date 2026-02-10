using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.Entities
{
   public class CommunityMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual void PrintInfo()
            {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            if (!string.IsNullOrEmpty(Phone))
                Console.WriteLine($"Phone: {Phone}");
        }
    }
}
