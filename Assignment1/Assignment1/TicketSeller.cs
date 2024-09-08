using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TicketSeller
    {
        private double amountToPay;
        private string name;
        private int numOfAdults;
        private int numOfChildren;
        private double price = 100.0;

        // Calculation method, just math.
        private void CalculateAmountToPay()
        {
            const double childDiscount = 0.25;
            amountToPay = (numOfAdults * price) + numOfChildren * (price * childDiscount);

        }
        // Reads inputs.
        public void ReadInput()
        {
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.Write("Number of adults: ");
            numOfAdults = int.Parse(Console.ReadLine());
            Console.Write("Number of children: ");
            numOfChildren = int.Parse(Console.ReadLine());
        }
        // Prints outputs.
        private void ShowResults()
        {
            Console.WriteLine("\t+++ Your Receipt +++");
            Console.WriteLine($"\t+++ Amount to pay = {amountToPay:F1} +++");
            Console.WriteLine($"\t+++ Price per ticket = {price:F1} +++");
            Console.WriteLine($"\t+++ Thank you {name} and please comeback! +++");

        }

        public void Start()
        {
            Console.WriteLine("\nWelcome to KIDS'fair\nChildren get always 75% discount!\n");

            ReadInput();
            CalculateAmountToPay();
            ShowResults();
        }
    }
}
