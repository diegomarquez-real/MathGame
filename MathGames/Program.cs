using System;

namespace MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChoose to Add, Multiply, Divide, or Subtract!");
            Console.WriteLine("\n1. Add");
            Console.WriteLine("\n2. Multiply");
            Console.WriteLine("\n3. Divide");
            Console.WriteLine("\n4. Subtract");

            bool why = true;

            do
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 4)
                    {
                        do
                        {
                            Console.WriteLine("\nEnter a number from 1 to 4!");
                            input = int.Parse(Console.ReadLine());
                        }
                        while (input < 1 || input > 4);
                    }
                    if (input == 1)
                    {
                        Console.WriteLine($"\nProblem type chosen: {input}");
                        Add add = new Add();
                        add.Addition();
                    }
                    if (input == 2)
                    {
                        Console.WriteLine($"\nProblem type chosen: {input}");
                        Multiply multiply = new Multiply();
                        multiply.Multiplication();
                    }
                    if (input == 3)
                    {
                        Console.WriteLine($"\nProblem type chosen: {input}");
                        Divide divide = new Divide();
                        divide.Division();
                    }
                    if (input == 4)
                    {
                        Console.WriteLine($"\nProblem type chosen: {input}");
                        Subtract subtract = new Subtract();
                        subtract.Subtraction();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nONLY NUMBERS HERE! NO DECIMALS ALLOWED EITHER!");
                    Console.WriteLine("\nEnter a valid number.");
                    why = false;

                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNUMBER YOU ENTERED WAS OUT OF RANGE!");
                    Console.WriteLine("\nEnter a valid number!");
                    why = false;

                }
            } while (why != true);

            Console.ReadKey();         
        }
    }
}
