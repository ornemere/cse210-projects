using System;

class Program
{
    static void Main()
    {
        int percent;
        while (true)
        {
            Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();


            if (int.TryParse(input, out percent))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        string letter;
        if (percent >= 90)      letter = "A";
        else if (percent >= 80) letter = "B";
        else if (percent >= 70) letter = "C";
        else if (percent >= 60) letter = "D";
        else                    letter = "F";

        string sign = "";
        int lastDigit = percent % 10;

        if (letter == "A")
        {
            if (percent < 93) sign = "-";
            else sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }
        else
        {
            if (lastDigit >= 7)      sign = "+";
            else if (lastDigit < 3)  sign = "-";
            else                     sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying—you’ll do better next time!");
        }
    }
}
