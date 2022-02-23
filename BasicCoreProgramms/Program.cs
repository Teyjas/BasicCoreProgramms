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

}



