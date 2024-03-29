using System;

namespace HelloGoodbye_CepilloCharlotte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop through numbers from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Check if the number is a multiple of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }
                // Check if the number is a multiple of 3 only
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                // Check if the number is a multiple of 5 only
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                // If the number is not a multiple of 3 or 5, print the number
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}