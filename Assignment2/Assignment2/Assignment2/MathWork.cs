using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MathWork
    {
        public void Calculate()
        {
            // Display header.
            Console.WriteLine("Sum numbers between any two numbers");
            Console.WriteLine("Give start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Give end number: ");
            int end = int.Parse(Console.ReadLine());

            // Perform various calculations.
            SumNumbers(start, end);
            PrintEvenNumbers(start, end);
            PrintOddNumbers(start, end);
            CalculateSquareRoots(start, end);

            // Prompt to exit or continue calculation.
            ExitCalculation();
        }

        private void CalculateSquareRoots(int num1, int num2)
        {
            Console.WriteLine("\n******** Square roots ***********");

            // Nested loops to calculate and display square roots.
            for (int i = num2; i <= num1; i++)
            {
                Console.Write($"Sqrt({i} to {num1})  ");
                for (int j = i; j <= num1; j++)
                {
                    double squareRoot = Math.Sqrt(j);
                    Console.Write($"{squareRoot:F2}\t");
                }
                Console.WriteLine();
            }
        }

        private bool ExitCalculation()
        {
            while(true) {
                Console.Write("Want to exit? (y/n): ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    return false;
                }
                else if (userInput == "n")
                {
                    Calculate();
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        // Method to print even numbers between two given numbers.
        private void PrintEvenNumbers(int number1, int number2)
        {
            if (number1 > number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            Console.WriteLine($"\n****Even numbers between {number1} and {number2}:");

            // Loop to find and display even numbers.
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /*      private void printMultiplicationTable()
                {

                }*/

        // Method to print odd numbers between two given numbers.
        private void PrintOddNumbers(int number1, int number2)
        {
            if (number1 > number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            Console.WriteLine($"\n****Odd numbers between {number1} and {number2}:");

            // Loop to find and display odd numbers
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Method to calculate and display the sum of numbers between two given numbers.
        public int SumNumbers(int start, int end)
        {
            int frml = start - end + 1;
            int sum = frml/2 * (start + end);

            Console.WriteLine($"The sum of numbers between {start} and {end} is: {sum}");

            return sum;
        }
    }
}
