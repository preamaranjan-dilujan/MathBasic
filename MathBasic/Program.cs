using System;

namespace MathBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDigitInANumber(12345);

        }

        static void CountDigitInANumber(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10; // Remove the last digit
                count++; // Increment the count
            }
            Console.WriteLine($"The number of digits is: {count}");

        }
    }
}