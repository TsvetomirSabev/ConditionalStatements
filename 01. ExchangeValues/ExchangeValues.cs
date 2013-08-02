// Write an if statement that examines two integer variables and exchanges their 
// values if the first one is greater than the second one.


using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number:");
        int firstVar = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter other integer number:");
        int secondVar = int.Parse(Console.ReadLine());
        
        if (firstVar < secondVar)
        {
            Console.WriteLine("First integer -> {0}; Second integer -> {1}",
            firstVar, secondVar);
        }
        else if (firstVar > secondVar)
        {
            int thirdVar = 0;            
            thirdVar = firstVar;
            firstVar = secondVar;
            secondVar = thirdVar;

            Console.WriteLine("Exchange values: First integer -> {0}; Second integer -> {1}"
            , firstVar, secondVar);
        }
    }
}

