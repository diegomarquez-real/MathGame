using System;
using System.Collections.Generic;
using System.Text;

namespace MathGames
{
    class Subtract
    {
        public void Subtraction()
        {
            Random a = new Random();
            Random b = new Random();
            bool why = true;
            int input = 0;
            int x = 0;

            Console.WriteLine("\nEnter number of questions you want to solve from 1 - 10!");

            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 10)
                    {
                        do
                        {
                            Console.WriteLine("\nEnter number of questions you want to solve from 1 - 10!");
                            input = int.Parse(Console.ReadLine());
                        }
                        while (input < 1 || input > 10);
                    }

                    Console.WriteLine($"\nNumber of problems chosen: {input}");

                    Console.WriteLine($"\nYou are testing Subtraction and the amount of problems is {input}.");

                    for (int i = input; i >= 1; i--)
                    {
                        string correct = "Correct!";
                        string wrong = "Wrong!";
                        int c = a.Next(1, 20);
                        int d = b.Next(1, 20);
                        if (c > d)
                        {
                            int subtract = c - d;
                            Console.WriteLine($"\n{c} - {d} = ");
                            Console.WriteLine("\nInput your answer please!");
                            decimal input2 = decimal.Parse(Console.ReadLine());
                            if (input2 == subtract)
                            {
                                x += 1;
                                Console.WriteLine($"\n{input2} is....{correct}");
                            }
                            else
                            {
                                Console.WriteLine($"\n{wrong} The correct answer is: {input2}");
                            }
                        }
                        if (c < d)
                        {
                            int subtract2 = d - c;
                            Console.WriteLine($"\n{d} - {c} = ");
                            Console.WriteLine("\nInput your answer please!");
                            int input2 = int.Parse(Console.ReadLine());
                            if (input2 == subtract2)
                            {
                                x += 1;
                                Console.WriteLine($"\n{input2} is....{correct}");
                            }
                            else
                            {
                                Console.WriteLine($"\n{wrong} The correct answer is: {input2}");
                            }
                        }

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
            decimal y = x;
            decimal y2 = input;
            decimal grade = (y / y2) * 100;
            decimal y3 = Math.Round(grade, 2);
            Console.WriteLine($"\nYou got {x} out of {input} correct! Your grade is {y3}!");
        }
    }
}
