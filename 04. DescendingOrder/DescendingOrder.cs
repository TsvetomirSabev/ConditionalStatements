// Sort 3 real values in descending order using nested if statements.

using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter one number:");
        double num1 = double.Parse(Console.ReadLine());
         
        Console.WriteLine("Enter other number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter final number:");
        double num3 = double.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0};{1};{2}", num1, num2, num3);
                }
                else 
                {
                    Console.WriteLine("{0};{1};{2}", num1, num3, num2);
                }
            }
            else if (num3 > num1)
            {
                Console.WriteLine("{0};{1};{2}", num3, num1, num2);
            }
        }

        else if (num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine("{0};{1};{2}",num2, num1, num3);
            }
            else
            {
                Console.WriteLine("{0};{1};{2}", num2, num3, num1);
            }
        }
        else
        {
            Console.WriteLine("{0};{1};{2}", num3, num2, num1);
        }
    }
}

