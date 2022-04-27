using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thousands();
            MultiplyByThree();
            //AccountCheck(int accountOne, int accountTwo);
            //EvenOrOdd();

        }

        //Write a method that will print to the console all numbers 1000 through -1000
        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void MultiplyByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        //Account number verifitcation tool.
        public static bool AccountCheck(int accountOne, int accountTwo)
        {
            if (accountOne == accountTwo)
            {
                Console.WriteLine("Your account has been verified");
                return true;
            }
            else 
            {               
                Console.WriteLine("Your account has not been verified, please try again.");
                return false;
            }

        }

        //Write a method to check whether a method to check whther a given number is even or odd
        public static void EvenOrOdd()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("You found an even number");
            }
            else
            {
                Console.WriteLine("You foun an odd number");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static bool PositiveCheck(int numberOne)
        {

            if (numberOne > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote
        public static bool MeetsVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"The voter is {age} years old and meets voting age.");
                return true;
            }
            else
            {
                Console.WriteLine($"The voter is {age} years old and does not meet the required voting age.");
                return false;
            }
        }

    }
}
