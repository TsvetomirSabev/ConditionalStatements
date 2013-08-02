// Write a program that finds the greatest of given 5 variables.

using System;

class GreatestVariable
{
    static void Main()
    {
        Console.WriteLine("Enter firts number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        double num3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter fourth number:");
        double num4 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter fifth number:");
        double num5 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3) && (num1 > num4) && (num1 > num5))
        {
            Console.WriteLine("Greatest variable -> " + num1);
        }
        else if ((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5))
        {
            Console.WriteLine("Greatest variable -> " + num2);
        }
        else if ((num3 > num1) && (num3 > num2) && (num3 > num4) && (num3 > num5))
        {
            Console.WriteLine("Greatest variable -> " + num3);
        }
        else if ((num4 > num1) && (num4 > num2) && (num4 > num3) && (num4 > num5))
        {
            Console.WriteLine("Greatest variable -> " + num4);
        }
        else
        {
            Console.WriteLine("Greatest variable -> " + num5);
        }
    }
}

