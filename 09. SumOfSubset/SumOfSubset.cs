// We are given 5 integer numbers. Write a program that checks if the sum of 
// some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class SumOfSubset
{
    static void Main()
    {
        Console.WriteLine("Enter five integer numbers:");
        int[] fiveN = new int[5];
        int result = 0;
        int counter = 0;
        for (int i = 0; i < 5; i++)
        {
            fiveN[i] = int.Parse(Console.ReadLine());
        }

        double pow = Math.Pow(2, 5) - 1;

        for (int position = 0; position < pow; position++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (((position & (1 << i)) >> i) == 1)
                {
                    result += fiveN[i];
                }
            }
            if (result == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} sum of 0", counter);
    }
}

