using System;

class Armstrong
{
    static void Main(string[] args)
    {
        Console.WriteLine("Armstrong numbers between 1 and 1000 are:");

        for (int i = 1; i <= 1000; i++)
        {
            if (IsArmstrong(i))
            {
                Console.WriteLine(i + " ");
            }
        }
    }
    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int remainder, result = 0;
        int n = originalNumber.ToString().Length;

        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, n);
            originalNumber /= 10;
        }

        return result == number;
    }
}