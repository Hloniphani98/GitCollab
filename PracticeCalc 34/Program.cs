using System;

class Program
{
    //comments
    static void Main()

    // Entry point of the application
    {
        Console.WriteLine("Console Calculator App");
        Console.WriteLine("----------------------");

        while (true)
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    continue;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (y/n): ");
            string again = Console.ReadLine();
            if (!again.Equals("y", StringComparison.OrdinalIgnoreCase))
                break;
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
