using System;
using System.IO;
using System.Xml;

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
                    "   \n1)TXT file" + "   \n2)JSON file" + "   \n3)XML fil2" + "   \n4)0 Exit the application");
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
                        Console.WriteLine("TXT");
                        Console.WriteLine("================================");
                        TextReader();
                        break;
                    case '2':
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Json");
                        Console.WriteLine("===================================");
                        JsonRader();
                        break;
                    case '3':
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("XML");
                        Console.WriteLine("===================================");
                        XmlReader();
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
        /// <summary>
        /// 
        /// </summary>
        static void JsonRader()
        {
            try
            {
                string st = File.ReadAllText(@"C:\Users\User\Source\Repos\FileReader2\Filereader\Filereader\Files\json.json");
                Console.WriteLine(st);
            }
            catch (Exception m)
            {
                Console.WriteLine("Sorry the file is not available at the moment to read.");
                Console.WriteLine(m.Message);
            }
            Console.Read();
        }
        /// <summary>
        /// Read the file and display it line by line.
        /// then tells the user how many lines are in the file
        /// </summary>
        static void TextReader()
        {
            //Making sure that the file exist.
            try
            {
                int counter = 0;
                string line;
                StreamReader file = new StreamReader(@"C:\Users\User\Source\Repos\FileReader2\Filereader\Filereader\Files\TextFile1.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
                file.Close();
                Console.WriteLine("");
                Console.WriteLine("///////////////////////////There were {0} lines.///////////////////////////////", counter);
             }
            catch (Exception m)
            {
                Console.WriteLine("Sorry the file is not available at the moment");
                Console.WriteLine(m.Message);
            }
            Console.Read();
        }
        /// <summary>
        /// 
        /// </summary>
        static void XmlReader()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                string file =  @"C:\Users\User\Source\Repos\FileReader2\Filereader\Filereader\Files\XMLFile.xml";
                xmlDoc.Load(file);
                xmlDoc.Save(Console.Out);
                Console.Read();
            }
            catch (Exception m)
            {
                Console.WriteLine("Sorry the file is not available at the moment.");
                Console.WriteLine(m.Message);
            }
        }
    }
}