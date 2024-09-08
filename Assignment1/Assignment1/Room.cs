using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    // Had no idea what to choose from, since there is a lot of objects. So I let the user to decide.

    class Room
    {
        private double price;
        private string objName;
        private int numOfObj;

        private void ReadNameInput()
        {
            Console.Write("What is the name of the object: ");
            objName = Console.ReadLine();
        }

        private void ReadNumObj()
        {
            Console.Write($"How many {objName} do you have: ");
            numOfObj =  int.Parse(Console.ReadLine());
        }

        private void ReadPrice()
        {
            Console.Write($"What is the price of {objName}: ");
            price = double.Parse(Console.ReadLine());
        }

        private void PrintoutInformation()
        {
            Console.WriteLine($"\nThe name of object(s): {objName}");
            Console.WriteLine($"The amount of object(s): {numOfObj}");
            Console.WriteLine($"The price of object(s): {price:C}");

            double totalValue = CalculateTotalValue();
            Console.WriteLine($"The total value of {numOfObj} {objName}(s) in the room is: {totalValue:C}\n");
        }
        // DateToTime library, prints out current date by calling DateTime.Now.
        private void PrintoutDate()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDateTime = currentDate.ToString("dd MMMM yyyy");
            Console.WriteLine($"The current date is {formattedDateTime}");

        }
        // Simple calculation.
        private double CalculateTotalValue()
        {
            return numOfObj * price;
        }

        public void Start()
        {
            Console.WriteLine("\nInspect your room!\n");

            ReadNameInput();
            ReadNumObj();
            ReadPrice();
            PrintoutInformation();
            PrintoutDate();
        }

    }
}
