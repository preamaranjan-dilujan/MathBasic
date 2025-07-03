using System;

namespace MathBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // CountDigitInANumber(325345);
            CornerDigitsSum(5);

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
        static void CornerDigitsSum(int number)
        {
            int n = number;
            int count = 1;
            int lastDigit = 0, firstDigit = 0;
            while (n > 0)
            {
            int digit = n % 10;
            n = n / 10;
            if (count == 1)
            {
                lastDigit = digit;
            }
            if (count > 1 && n == 0)
            {
                firstDigit = digit;
            }
            count++;
            }
            Console.WriteLine(lastDigit + firstDigit);
        }

    }
}