
using System;
using System.Net.Cache;

namespace Week2Ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            int Age;
            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);
            if (Age < 18)
            {
                Console.WriteLine($"you`re {Age}, you`re too young.");
            } else if (Age > 18)
            {
                Console.WriteLine($"you are {Age}, you are old enough");
            } else
            {
                Console.WriteLine($"Congratulations! you are {Age}");
            }
        }
    }
}
