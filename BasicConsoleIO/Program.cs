using System;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            FormatNumericalData();
            DisplayMessage();
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            //Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            //Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            //Restore previous color.
            Console.ForegroundColor = prevColor;
        }

        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 9999);
            Console.WriteLine("d9 format: {0:d9}", 9999);
            Console.WriteLine("f3 format: {0:f3}", 9999);
            Console.WriteLine("n format: {0:n}", 9999);

            //Notice that upper- or lowercasing for hex
            //determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 9999);
            Console.WriteLine("e format: {0:e}", 9999);
            Console.WriteLine("X format: {0:X}", 9999);
            Console.WriteLine("x format: {0:x}", 9999);
        }

        static void DisplayMessage()
        {
            //Using string.Format() to format a string literal.
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
