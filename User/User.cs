using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        private static int counter = 0;
        public int Id { get; set; }
        static User()
        {
            Console.WriteLine("First user is created");
        }
        public User()
        {
            Id = ++counter;
        }
       
        public static void Display()
        {
            Console.WriteLine($"{counter}");
        }
    }
}
