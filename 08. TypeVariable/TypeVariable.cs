/* Write a program that, depending on the user's choice inputs int, double or string
 * variable. If the variable is integer or double, increases it with 1. If the 
 * variable is string, appends "*" at its end. The program must show the value of 
 * that variable as a console output. Use switch statement.*/

using System;

class TypeVariable
{
    static void Main()
    {
        Console.WriteLine("Enter 0 for integer number,");
        Console.WriteLine("enter 1 for double number,");
        Console.WriteLine("or enter 2 for string:");
        int variable = int.Parse(Console.ReadLine());

        switch (variable)
        {
            case 0: Console.WriteLine("Enter one integer number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Your choise is increase -> {0} ", num1 + 1);
                break;
            case 1: Console.WriteLine("Enter one double number:");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Your choise is increase -> {0} ", num2 + 1);
                break;
            case 2: Console.WriteLine("Enter some string:");
                string someStr = Console.ReadLine();
                Console.WriteLine("{0}", someStr + '*');
                break;
            default: Console.WriteLine("Wrong digit!");
                break;
        }
    }
}

