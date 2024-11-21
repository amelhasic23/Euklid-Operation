using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter two numbers to find their GCD:");

                // Validacija unosa
                Console.Write("Enter the first number: ");
                int a = ValidateInput(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int b = ValidateInput(Console.ReadLine());

                // Izračunavanje i ispis rezultata
                Console.WriteLine($"The GCD of {a} and {b} is: {FindGCDEuclid(a, b)}");

                // Opcija za izlaz ili ponavljanje
                Console.WriteLine("Do you want to calculate another GCD? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }

            Console.Clear();
        }
    }

    static int ValidateInput(string input)
    {
        if (!int.TryParse(input, out int number))
        {
            throw new Exception("Invalid input. Please enter a valid integer.");
        }

        return Math.Abs(number); // Uvek vraća pozitivnu vrednost
    }

    static int FindGCDEuclid(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
