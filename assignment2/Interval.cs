//ANANDHA PADMANABHAN KUNNAPPILLY UNNIKRISHNAN C0894441
using System;
class Interval
{
   static void Main(string[] args)
   {
       Console.WriteLine("Enter a real number:");
       double x;

       if (double.TryParse(Console.ReadLine(), out x))
       {
           bool isInInterval = 
               // Check for inclusion in interval I ([2, 3[) using only < and ==
               ((x >= 2 && x < 3) 
               // Check for inclusion in interval II (]0, 1]) using only < and ==
               || (x > 0 && x <= 1)
               // Check for inclusion in interval III ([-10, -2]) using only < and ==
               || (x > -10 && x <= -2));

           if (isInInterval)
           {
               Console.WriteLine("x belongs to I");
           }
           else
           {
               Console.WriteLine("x does not belong to I");
           }
       }
       else
       {
           Console.WriteLine("Invalid input. Please enter a valid real number.");
       }
   }
}