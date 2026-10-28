using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int newMagicNumber = randomGenerator.Next(1, 100);


        bool correct = false;

        while (correct == false)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            float newGuess = float.Parse(guess);

            if (newGuess > newMagicNumber)
            {
                Console.WriteLine("Lower");
                correct = false;
            }

            else if (newGuess < newMagicNumber)
            {
                Console.WriteLine("Hihger");
                correct = false;
            }

            else
            {
                Console.WriteLine("You guessed it!");
                correct = true;
            }
        }
    }
}