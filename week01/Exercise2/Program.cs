using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float newPercentage = float.Parse(percentage);
        string letter = "";

        if (newPercentage >= 90)
        {
            letter = "A";
        }

        else if (newPercentage >= 80)
        {
            letter = "B";
        }

        else if (newPercentage >= 70)
        {
            letter = "C";
        }

        else if (newPercentage >= 60)
        {
            letter = "D";
        }

        else if (newPercentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (newPercentage >= 70)
        {
            Console.WriteLine("Congratulation, you passed this course!!!");
        }

        else
        {
            Console.WriteLine("Unfortunately you didn't pass the course this time... Better luck next time!");
        }

    }
}