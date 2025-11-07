using System;
using System.Collections.Generic; // necesario para usar List<T>

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>(); // lista vacía

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    break; // termina el ingreso
                }

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // Si la lista está vacía
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // --- Core Requirements ---
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        double average = (double)sum / numbers.Count;
        int max = int.MinValue;

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch Challenges ---
        // 1) Encontrar el menor positivo
        int? smallestPositive = null;
        foreach (int n in numbers)
        {
            if (n > 0)
            {
                if (smallestPositive == null || n < smallestPositive)
                {
                    smallestPositive = n;
                }
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // 2) Ordenar y mostrar lista
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
