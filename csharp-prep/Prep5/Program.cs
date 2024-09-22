using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredNumber);

    }

    //Console.WriteLine("Hello Prep5 World!");

    static void DisplayMessage()
    {
        Console.WriteLine("welcome to the programe");
    }

    static string PromptUserName()
    {
        Console.WriteLine("please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("please enter your favourite number : ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {

        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
    }

}