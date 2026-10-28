using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string userNumber = "";

        while (userNumber != "0")
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            float newUserNumber = float.Parse(userNumber);
            if (newUserNumber != 0)
            {
                numbers.Add(newUserNumber);
            }
        }

        float sum = 0;
        float largest = 0;

        foreach (float number in numbers)
        {
            Console.WriteLine(number);

            if (number > largest)
            {
                largest = number;
            }

            sum = sum + number;


        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}