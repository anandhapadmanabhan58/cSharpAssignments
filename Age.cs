using System;
class Age
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provide your age:");
        int age= Convert.ToInt32(Console.ReadLine());;
        int yearOfBirth = 2024 - age;
        Console.WriteLine("Your year of birth is " + yearOfBirth);
    }
}
