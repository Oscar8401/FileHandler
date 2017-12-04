using System;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n         Welcome user!");
            bool userChoose = true;

            while (userChoose)
            {
                Console.WriteLine("You have three files in the libary" +
                    "   \n1)Json file" + "   \n2)XML file" + "   \n3)Txt file" + "   \n4)0 Exit the application");
                var userInput = ' ';
                try
                {
                    userInput = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please choose something! ");
                }


                switch (userInput)
                {
                    case '1':
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Jaon file");
                        break;
                    case '2':
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("XML file");
                        break;
                    case '3':
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Txt file");
                        break;
                    case '4':
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("case4");
                        break;
                    case '0':
                        Console.Clear();
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Invalid Input. Try again! 0,1,2,3");
                        break;
                }
                Console.ReadLine();
            }
        }
        static void JsonRader() { }
        static void TextReader() { }
        static void XmlReader() { }
    }
}