using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {
        private bool done = false;
        private int userChoice;

        private void converter()
        {
            if (userChoice == 1)
            {
                // Convert Fahrenheit to Celsius.
                for (double fahrenheit = 0; fahrenheit <= 210; fahrenheit += 10)
                {
                    double celsius = 5.0 / 9.0 * (fahrenheit - 32);
                    Console.WriteLine($"\t{fahrenheit:F2} F = " + $"{celsius:F2} C");
                }
            }
            else if (userChoice == 2)
            {
                // Convert Celsius to Fahrenheit.
                for (double celsius = 0; celsius <= 100; celsius += 5)
                {
                    double fahrenheit = 9.0 / 5.0 * celsius + 32;
                    Console.WriteLine($"\t{celsius:F2} C = " + $"{fahrenheit:F2} F");
                }
            }
            else if (userChoice == 0)
            {
                // Set the flag to indicate the conversion is done.
                done = true;
            }
            else
            {
                // Error message for an invalid choice.
                Console.WriteLine("Invalid choice. Try again!");
            }
        }

        // Method to display the conversion options and get user's choice.
        private void displayList()
        {
            while (!done)
            {
                Console.WriteLine("\nConvert Fahrenheit to Celsius: 1");
                Console.WriteLine("Convert Celsius to Fahrenheit: 2");
                Console.WriteLine("Exit the converter: 0");
                Console.Write("Your Choice: ");

                // Will read user input.
                userChoice = int.Parse(Console.ReadLine());
                converter();
            }
        }

        // Method to start the temperature converter.
        public void Start()
        {
            displayList();
        }
    }
}
