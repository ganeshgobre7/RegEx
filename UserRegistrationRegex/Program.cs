using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE USER REGISTRATION REGEX PROBLEM");

            Patterns patterns = new Patterns();//creating object of pattern class
            int defCount = 0;
            while (defCount == 0)
            {
                Console.WriteLine("1.First Name 2.Last Name 3.E-mail 4.Mobile Number 5.Password 6.Exit");
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
                    case 3:
                        Console.Write("Insert the Email Id :");
                        string str2 = Console.ReadLine();
                        Console.WriteLine(patterns.eMail(str2));
                        break;
                    case 4:
                        Console.Write("Insert Mobile Number :");
                        string str3 = Console.ReadLine();
                        Console.WriteLine(patterns.mobNumber(str3));
                        break;
                    case 5:
                        Console.Write("Insert the Password :");
                        string str4 = Console.ReadLine();
                        Console.WriteLine(patterns.password(str4));
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
