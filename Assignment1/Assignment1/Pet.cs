using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Pet
    {
        private int age;
        private bool isFemale;
        private string name;

        public void DisplayPetInfo()
        {

            Console.WriteLine("Pet's information:\n");

            // Will print out the output based on true/false. 
            if (isFemale == true)
            {
                Console.WriteLine($"Name: {name} " + $"Age: {age}\n" + $"{name}: She's such a wonderful pup!");

            }
            else
            {
                Console.WriteLine($"Name: {name} " + $"Age: {age}\n" + $"{name}: He's such a wonderful pup!");

            }
        }
        
        // Just reading name, age and boolean, which will set it with if statement by user's answer.
        public void ReadAndSavePetData()
        {
            Console.Write("Please provide pets name: ");
            name = Console.ReadLine();
            Console.Write("What's the age of the pet: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Is it female: Y for yes, N for no: ");
            string userAns = Console.ReadLine();

            if (userAns == "Y" || userAns == "y")
            {
                isFemale = true;
            }
            else if (userAns == "N" || userAns == "n")
            {
                isFemale = false;
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
            }

        }

        public void Start()
        {
            Console.WriteLine("\nGreetings from the pet class!\n");

            ReadAndSavePetData();
            DisplayPetInfo();
        }
    }
}
