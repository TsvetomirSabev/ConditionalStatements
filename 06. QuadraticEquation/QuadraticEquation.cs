// Write a program that enters the coefficients a, b and c of a quadratic equation
// a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic
// equations may have 0, 1 or 2 real roots.


using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Quadratic equation-> ax2+bx+c=0");
        Console.WriteLine("Enter value for a (different by zero!):");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for c:");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0)
        {
            double firstRoot = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = ((-b) - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("Two real roots! First -> {0:F2}; Second ->{1:F2}",
                firstRoot, secondRoot);
        }
        else if (discriminant == 0)
        {
            double oneRoot = (-b) / (2 * a);

            Console.WriteLine("One real root! -> {0:F2}", oneRoot);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
    }
}

