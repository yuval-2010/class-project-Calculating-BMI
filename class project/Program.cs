using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the GYM website");
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name);

        Console.WriteLine("What's your age?");
        int age = Int32.Parse(Console.ReadLine());
        if (age < 7)
        {
            Console.WriteLine("You can't use this website.");
            return; // Exit the program if age is less than 7
        }
        else
        {
            Console.WriteLine("Your age is good for this website.");
        }

        Console.WriteLine("What is your weight in KG?");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your height in cm?");
        double heightInCm = double.Parse(Console.ReadLine());

        // Convert height from cm to meters
        double heightInMeters = heightInCm / 100;

        // Correct BMI formula
        double bmi = weight / (heightInMeters * heightInMeters);

        // Display the BMI result with appropriate category
        if (bmi < 18.5)
        {
            Console.WriteLine("Your BMI is underweight.");
        }
        else if (bmi >= 18.5 && bmi <= 24.9) // adjusted the normal range upper bound
        {
            Console.WriteLine("Your BMI is in the normal weight range.");
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("Your BMI is in the overweight range.");
        }
        else
        {
            Console.WriteLine("Your BMI is in the obesity range.");
        }
    }
}
