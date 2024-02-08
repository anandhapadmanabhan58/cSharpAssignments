using System;
class Degree3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a (int): ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter b (int): ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter c (int): ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter x (double): ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Auxiliary variables for efficiency
        double sumDivideByTwo = (a + b) / 2.0;
        double sumSquare = Math.Pow(a + b, 2);

        // Evaluating the polynomial
        double result = (sumDivideByTwo * Math.Pow(x, 3)) + (sumSquare * Math.Pow(x, 2)) + (a + b + c);

        Console.WriteLine($"The value of polynomial is {result}");
    }
}
