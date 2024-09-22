using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> listOfNumbers = new List<int>();

        int number = -1;
        int sum = 0;


        Console.WriteLine("Enter a list of numbers type 0 when finished. ");
        //Console.Write("Enter number");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            listOfNumbers.Add(number);
        }

        int itemCount = listOfNumbers.Count;
        itemCount = itemCount - 1;
        int largestNumber = listOfNumbers.Max();

        foreach (int items in listOfNumbers)
        {
            sum += items;
        }

        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine($"The average is {sum / itemCount}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}