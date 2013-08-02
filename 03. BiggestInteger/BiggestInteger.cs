// Write a program that finds the biggest of three integers using nested 
// if statements.

using System;

class BiggestInteger
{
    static void Main()
    {
        Console.WriteLine("Enter one number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter other number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter final number:");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("Biggest number -> " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("Biggest number -> " + num2);
        }
        else 
        {
            Console.WriteLine("Biggest number -> " + num3);
        }
    }
}

