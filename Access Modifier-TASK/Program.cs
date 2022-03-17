using System;

namespace Access_Modifier_TASK
{
    public class Program
    {
        static void Main(string[] args)
        {
            User username = new User();

            User password = new User();

            Console.WriteLine("Username daxil edin: ");

            username.Username = Console.ReadLine();

            Console.WriteLine("Password daxil edin");

            password.Password = Console.ReadLine();


            Admin admin = new Admin(true, "Correct");

        }
    }
}
