using System;
using ConsoleApp58.Interface;

namespace ConsoleApp58
{
    class Program
    {
        private static object password;
        static void Main(string[] args)
        {
            Console.WriteLine("sifreni yeniden daxil edin");

            string password = Console.ReadLine();
            string email = "Said";
            User user = new User(email, password);


            user.FullName = "Said Zahiodv";
            user.ShowInfo();
        }
    }
}
