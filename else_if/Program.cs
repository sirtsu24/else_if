using System;

namespace else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string firstName;
            string lastName;
            int yearOfBirth;

            Console.WriteLine("What's your name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}!");

            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"You are {2019-yearOfBirth} year old");

            Console.ReadLine();*/

            /*Start:
            int userNumber;
            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber < 5)
            {
                Console.WriteLine($"{userNumber} is less than 5");
            }

            else if (userNumber > 5)
            {
                Console.WriteLine($"{userNumber} is greater than 5");

            }

            else if (userNumber == 5)
            {
                Console.WriteLine($"{userNumber} is equals 5");
            }

            Console.ReadLine();
            goto Start;*/

            int userNumber;

            Console.WriteLine("Enter a number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {
                if (userNumber < 5)
                {
                    Console.WriteLine($"{userNumber} is less than 5");
                }
                else if (userNumber > 5)
                {
                    Console.WriteLine($"{userNumber} is greater than 5");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is equals 5");
                }

            }
            else
                Console.WriteLine("Püsi etteantud vahemikus!");


            Console.ReadLine();
        }
    }
}
