using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    class PhoneBook
    {

        private string[] names = { "Dr.Och", "Zan", "Adam", "Nasral", "Bob" };
        private string[,] phoneList;
        private string[] phones = { "040-4264", "040-1693", "040-9088", "040-4221", "040-7121" };

        public PhoneBook()
        {
            displayList();
            Console.WriteLine();

            // Sorted list.
            sortByName();
            Console.WriteLine("\nSorted List:\n");
            displayList();

            // Two-dimensional.
            int count = names.Length;
            phoneList = new string[count, 2];
            fillTable();

            Console.WriteLine("\nUsing a 2d array insead of two 1d arrays:\n");
            displayTable();
        }

        // Display the list of names and corresponding phones.
        private void displayList()
        {
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine($"{names[i],-10}   {phones[i],-10}");
            }
        }

        // Display the two-dimensional table of names and phones.
        private void displayTable()
        {
            for (int row = 0; row < names.Length; row++)
            {
                Console.WriteLine($"Row {row}   {phoneList[row, 0],-10}   {phoneList[row, 1],-10}");
            }
        }

        // Fill the two-dimensional phoneList array with names and phones.
        private void fillTable()
        {
            for (int i = 0; i < names.Length; i++)
            {
                phoneList[i, 0] = names[i];
                phoneList[i, 1] = phones[i];
            }
        }

        // Sort the names array alphabetically and swap corresponding phones.
        private void sortByName()
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        swapValues(j); // swap values if names are out of order.
                    }
                }
            }
        }

        // Swap names and corresponding phones at position pos and pos + 1.
        private void swapValues(int pos)
        {
            (names[pos], names[pos + 1]) = (names[pos + 1], names[pos]);
            (phones[pos], phones[pos + 1]) = (phones[pos + 1], phones[pos]);
        }
    }
}
