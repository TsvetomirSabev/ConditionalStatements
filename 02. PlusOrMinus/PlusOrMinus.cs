// Write a program that shows the sign (+ or -) of the product of three real 
// numbers without calculating it. Use a sequence of if statements.

using System;

class PlusOrMinus
{
    static void Main()
    {
        Console.WriteLine("Enter one number:");
        double num1 = double.Parse(Console.ReadLine());
         
        Console.WriteLine("Enter other number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter final number:");
        double num3 = double.Parse(Console.ReadLine());

        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("No sigh(product = 0)");
        }
        else if (num1 < 0 ^ num2 < 0 ^ num3 < 0)
        {
            Console.WriteLine("The sign is '-'");
        }
        else 
        {
            Console.WriteLine("The sign is '+'");
        }
    }
}

