namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupConsoleWindow();

            Pet petObj = new Pet();
            petObj.Start();

            Console.WriteLine("\nPress enter to start the next part\n");
            Console.ReadKey();

            TicketSeller ticketObj = new TicketSeller();
            ticketObj.Start();

            Console.WriteLine("\nPress enter to start the next part\n");
            Console.ReadKey();

            Album albumObj = new Album();
            albumObj.Start();

            Console.WriteLine("\nPress enter to start the next part\n");
            Console.ReadKey();

            Room roomObj = new Room();
            roomObj.Start();
        }

        static void SetupConsoleWindow()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "My Console classes";
        }
    }
}
