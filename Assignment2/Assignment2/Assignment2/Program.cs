namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Assignment 2 <By: Eldaras Zutautas>";

            ContinueToNextPart("Temperature Converter");

            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            ContinueToNextPart("String Functions");

            StringFunctions sFunc = new StringFunctions();
            sFunc.Start();

            ContinueToNextPart("Math Work");

            MathWork mathWork = new MathWork();
            mathWork.Calculate();

        }

        // Static is more efficient by allowing other classes to employ it without creating an instance.
        private static void ContinueToNextPart(string title)
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
            Console.Title = title;
            Console.WriteLine("++++++++ " + title + " ++++++++");
        }
    }
}
