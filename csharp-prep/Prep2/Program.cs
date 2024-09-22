using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string grade = Console.ReadLine();

        int gradeNumber = int.Parse(grade);

        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (gradeNumber < 70)
        {
            Console.WriteLine("sorry you did not meet the requirement but please try again am sure you will do great. ");
        }
        else
        {
            Console.WriteLine("congratulations!! you passed.");
        }



    }
}