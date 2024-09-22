using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //Console.Write("what is the magic number ? ");
        //string numberS = Console.ReadLine();

        //int magicNumber = int.Parse(numberS);

        //string answer = "";
        int guess = -1;
        int numberOfGuesses = -1;


        //Console.WriteLine("would you like to play again ? ");
        //answer = Console.ReadLine();
        //while (answer == "yes")

            
           
            while (guess != magicNumber )

            {


                Console.Write("what is your guess ? ");
                guess = int.Parse (Console.ReadLine());

                numberOfGuesses = numberOfGuesses + 1;


                if (magicNumber > guess)

                {
                    Console.WriteLine("Lower");
                }

                else if (magicNumber < guess)

                {
                    Console.WriteLine("Higher");
                }

                else

                {
                    Console.WriteLine("you guessed it right");
                }

            }

            Console.WriteLine($"you made {numberOfGuesses} guess");

            //Console.WriteLine("would you like to play again ? ");
            //answer = Console.ReadLine();

            //while (answer == "yes")

            





            


    }
}