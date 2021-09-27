using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE USER REGISTRATION REGEX PROBLEM");

            Patterns patterns = new Patterns();
            int defCount = 0;
            while (defCount == 0)
            {
                Console.WriteLine("1.First Name 2.Last Name 3.Exit");
                Console.WriteLine("Choose Your Option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Insert the First Name :");
                        string str = Console.ReadLine();
                        Console.WriteLine(patterns.firstName(str));
                        break;
                    case 2:
                        Console.Write("Insert the Last Name :");
                        string str1 = Console.ReadLine();
                        Console.WriteLine(patterns.lastName(str1));
                        break;
                    default:
                        Console.WriteLine("End");
                        defCount++;
                        break;
                }
            }

        }
    }
}
