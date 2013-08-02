/* * Write a program that converts a number in the range [0...999] to a text 
 *  corresponding to its English pronunciation. Examples:
	  0 -> "Zero"
	273 -> "Two hundred seventy three"
	400 -> "Four hundred"
	501 -> "Five hundred and one"
	711 -> "Seven hundred and eleven"*/

using System;

class ConvertProgram
{
    static void Main()
    {
        Console.WriteLine("Please enter one number between 0 and 999:");
        int enter = int.Parse(Console.ReadLine());

        while ((enter < 0) || (enter > 999))
        {
            Console.WriteLine("Error! Wrong number!");
            return;
        }

        string[] digits = {"zero", "one", "two", "three", "four", "five", "six"
                              , "seven", "eight", "nine"};
        string[] teens = {"ten", "eleven", "twelve", "thirteen", "fourteen"
                             ,"fifteen", "sixteen", "seventeen", "eighteen"
                         , "nineteen"};
        string[] numbers = {"", "", "twenty", "thirty", "fourty", "fifty", "sixty"
                               , "seventy", "eighty", "ninety"};

        int unary = enter % 10;
        int binary = (enter / 10) % 10;
        int hundreds = (enter / 100) % 100;


        if (hundreds != 0)
        {
            Console.Write("{0} hundred ", digits[hundreds]);
            if (binary != 0 && binary != 1 && enter >= 20)
            {
                Console.Write("and {0} ", numbers[binary]);
                if (unary != 0)
                {
                    Console.Write("{0} ", digits[unary]);
                }
            }
            else if (binary == 1)
            {
                Console.Write("and {0}", teens[unary]);
            }
            else
            {
                if (unary != 0)
                {
                    Console.Write("and {0} ", digits[unary]);
                }
            }
        }
        else
        {
            if (binary != 0 && binary != 1 && enter >= 20)
            {
                Console.Write("{0} ", numbers[binary]);
                Console.Write("{0} ", digits[unary]);
            }
            else if (binary == 1)
            {
                Console.WriteLine("{0}", teens[unary]);
            }
            else
            {
                Console.WriteLine("{0} ", digits[unary]);
            }
        }
        Console.WriteLine();
    }
}

