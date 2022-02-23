using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms;

internal class BasicPrograms
{
    
    static Random random = new Random();

    
    public static void FlipCoin()
    {
        int count = 0;
        int headCount = 0;
        int tailCount = 0;
        float headPercent = 0;
        float tailPercent = 0;
        double toss = 0;

        do
        {
            Console.Write("Enter a positive integer: ");
            count = Convert.ToInt32(Console.ReadLine());
        } while (count < 0);
        for (int i = 0; i < count; i++)
        {
            toss = random.NextDouble();
            if (toss < 0.5)
                headCount++;
            else
                tailCount++;
        }
        headPercent = (float)headCount / (float)(headCount + tailCount);
        tailPercent = (float)tailCount / (float)(tailCount + headCount);
        Console.WriteLine("Head count: " + headCount + " Head Percent: " + headPercent);
        Console.WriteLine("Tail count: " + tailCount + " Tail Percent: " + tailPercent);
    }
    /// <summary>
    /// Checks for Leap year.
    /// </summary>
    public static void LeapYear()
    {
        int year = 0;
        do
        {
            Console.Write("Enter a year(yyyy): ");
            year = Convert.ToInt32(Console.ReadLine());
        } while (year / 1000 == 0);
        if (year % 4 == 0)
            Console.WriteLine("It is a leap year");
        else
            Console.WriteLine("It is not a leap year");
    }
    /// <summary>
    /// Power of 2 table for the specified n.
    /// </summary>
    public static void Power2()
    {
        int power_2;
        Console.WriteLine("Please enter value of n to print power of 2 table");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n >= 0 && n <= 30)
        {
            for (int i = 0; i <= n; i++)
            {
                power_2 = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine("2^" + i + " : " + power_2);
            }
        }
        else
            Console.WriteLine("Please Enter value of n from 0 to 30");
    }
    /// <summary>
    /// Calculates the Harmonic no of n
    /// </summary>
    public static void HarmonicNo()
    {
        int n = 0;
        float harmonic = 0;
        do
        {
            Console.Write("Enter a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 0);
        for (int i = 1; i <= n; i++)
            harmonic += (float)1 / (float)i;
        Console.WriteLine("Harmonic no of " + n + ": " + harmonic);
    }
    // Computes Quotient & Remainder using Dividend & Divisor as I/P
    public static void Factors()
    {
        int n = GetPositiveInt();
        bool prime = true;
        Console.WriteLine("The prime factors are: ");
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                prime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime is true)
                    Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    // Repeats input statement until user enter positive int
    private static int GetPositiveInt()
    {
        int n = 0;
        do
        {
            Console.Write("Enter a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 0);
        return n;
    }

    // Computes Quotient & Remainder using Dividend & Divisor as I/P
    public static void QuotientRem()
    {
        int quotient = 0;
        int remainder = 0;
        int dividend = 0;
        int divisor = 0;
        Console.WriteLine("Enter Dividend: ");
        dividend = GetPositiveInt();
        Console.WriteLine("Enter Divisor: ");
        divisor = GetPositiveInt();
        quotient = dividend / divisor;
        remainder = dividend % divisor;
        Console.WriteLine("Quotient: " + quotient + " Remainder: " + remainder);
    }
    // Swap 2 numbers
    public static void Swap()
    {
        int a = 0;
        int b = 0;
        int temp = 0;
        Console.WriteLine("Enter value for 'a': ");
        a = GetPositiveInt();
        Console.WriteLine("Enter value for 'b': ");
        b = GetPositiveInt();
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After Swapping....");
        Console.WriteLine("a: " + a + " b: " + b);
    }

}



