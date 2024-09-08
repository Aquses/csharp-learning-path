using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2
{
    class StringFunctions
    {
        private string text;
        private int userIntChoice;
        private bool done = false;

        // Method to calculate and display the length of the user-inputted string.
        private void StringLength()
        {
            Console.WriteLine("\n\nWrite a text with any number of characters and press Enter.");
            Console.WriteLine("You can even copy text from a file and paste it here!\n");
            text = Console.ReadLine();
            int length = text.Length;

            Console.WriteLine("\n ---- STRING LENGTH ----" );
            Console.WriteLine($"\n{text.ToUpper()}" + $"\nNumber of chars = {length}");

        }

        // Method to predict the user's day based on a selected number.
        private void PredictMyDay()
        {
            Console.WriteLine("\n\n *************** The Fortune Teller ***************");
            Console.Write("Let me predict your day! Select a number between 1 and 7: ");
            userIntChoice = int.Parse(Console.ReadLine());

            // Switch statement to provide different predictions based on user's choice.
            switch (userIntChoice)
            {
                case 1:
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case 2:
                    Console.WriteLine("Tuesdays break your heart!");
                    break;
                case 3:
                    Console.WriteLine("Wednesdays should not exist in a week.");
                    break;
                case 4:
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;
                case 5:
                    Console.WriteLine("Friday, you are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("Time to head to Church!");
                    break;
                default: 
                    Console.WriteLine("No day? A good day but it doesn't exist!");
                    break;
            }
        }

        // Method to prompt the user to run the string functions again or exit.
        private void RunAgain()
        {
            while(!done)
            {
                Console.Write("\nWilling to continue? (y/n): ");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "y")
                {
                    // If user wants to continue, run StringLength and PredictMyDay again.
                    StringLength();
                    PredictMyDay();
                }
                else if (userChoice == "n")
                {
                    // If user wants to exit, set the flag to true.
                    done = true;
                }
                else
                {
                    // Error message.
                    Console.WriteLine("\nInvalid choice. Try again.");
                }
            }
        }

        public void Start()
        {
            StringLength();
            PredictMyDay();
            RunAgain();
        }
    }
}
