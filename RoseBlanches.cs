using System;

class RoseBlanches
{
    static void Main(string[] args)
    {
        Console.Write("How much did you receive money ($)? ");
        double total=double.Parse(Console.ReadLine());

        double booksAndSupplies = 0.75 * total;
        double remainingMoney=total-booksAndSupplies;

        int coffeeCost = 2;
        int flashComputerCost = 4;
        int subwayCost = 3;

        int coffee=(int)((remainingMoney/3)/coffeeCost);
        int flashComputer=(int)((remainingMoney/3)/flashComputerCost);
        int subway=(int)((remainingMoney/3)/subwayCost);

        int finalMoney=(coffee*coffeeCost)+(flashComputer*flashComputerCost)+(subway*subwayCost);

        double roses = remainingMoney - finalMoney;

        Console.WriteLine("Books and Supplies: {0} $", booksAndSupplies);
        Console.WriteLine("You can then buy :");
        Console.WriteLine("{0} Coffees", coffee);
        Console.WriteLine("{0} Flash Computer Numbers", flashComputer);
        Console.WriteLine("{0} subway Tickets", subway);
        Console.WriteLine("and you will have {0} dollars for the white roses", roses);
    }
}