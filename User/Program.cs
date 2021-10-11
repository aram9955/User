using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            Console.WriteLine(user1.Id);
            Console.WriteLine(user3.Id);
            Console.WriteLine(user5.Id);

            User.Display();
        }
    }
}
