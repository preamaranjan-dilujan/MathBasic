using System;

namespace MathBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // CountDigitInANumber(325345);
            // CornerDigitsSum(5);
            // Console.WriteLine(kthDigit(5, 2, 2)); // Should return 4
            Console.WriteLine(PalindromeOfANumber(121)); // Should return "Palindrome"

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

        static int kthDigit(int a, int b, int k)
        {
            long value = (long)Math.Pow(a, b);
            int count = 1;
            int kthDigit = 0;
            while (value > 0)
            {
                int lastDigit = (int)(value % 10);
                if (count == k)
                {
                    kthDigit = lastDigit;
                }
                value = value / 10;
                count++;
            }
            return kthDigit;
        }

        static string PalindromeOfANumber(int number)
        {
            int originalNumber = number;
            int sum = 0;
            while (number > 0)
            {
            int lastDigit = number % 10;
            sum = (sum*10) + lastDigit;
            number = number / 10;
            }
            if (sum == originalNumber)
            {
            return "Palindrome";
            }
            else
            {
            return "Not Palindrome";
            }
        }

    }
}