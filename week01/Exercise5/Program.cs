using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);

        DisplayResult(name, squared);
    }

    // 1) Muestra el mensaje de bienvenida
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // 2) Pide y devuelve el nombre del usuario
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // 3) Pide y devuelve el número favorito (entero), con validación
    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                return value;
            }
            Console.WriteLine("Please enter a valid integer.");
        }
    }

    // 4) Devuelve el cuadrado del número
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // 5) Muestra el resultado final
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
