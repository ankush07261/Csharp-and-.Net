using System;
class Floyds
{
    static void Main()
    {
        int val = 1;
        Console.WriteLine("Enter the row size: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int[,] floyd = new int[10, 10];
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                floyd[i, j] = val;
                val++;
                Console.Write(floyd[i, j] + "\t");
            }
            Console.Write("\n");
        }
    }
}
