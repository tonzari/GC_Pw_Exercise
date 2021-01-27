using System;

namespace GC_Password_Exercise
{
    class Program
    {
        // Grand Circus - Password Registration Exercise
        // Antonio Manzari

        static void Main(string[] args)
        {
            string password;
            while (true)
            {
                Console.WriteLine("Please input a passwrod that satisfies the following rules: ");
                Console.WriteLine("1) The password must contain at least 1 lowercase letter");
                Console.WriteLine("2) Must contain at least 1 uppercase letter");
                Console.WriteLine("3) At least one number");
                Console.WriteLine("4) Min 7 characters and max 12 characters inclusive");
                Console.WriteLine("5) Have one of the following special characters: ! @ # $ % ^ & *");

                password = Console.ReadLine();
            }


        }
    }
}
