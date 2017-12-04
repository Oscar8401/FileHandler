using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Linq;
using System.Web.Script.Serialization;
//you should go to reference add reference and add system.web.extentions
//otherwise system.web.script.serialization will not work

namespace FileReader
{
    //creating class person to use it for json
    class Person
    {
        public string firstName { get; set; }
        public int age { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public bool newSubscription { get; set; }
        public string companyName { get; set; }
        public override string ToString()
        {
            return string.Format("FirstName: {0} \nLastname: {1} \nAge: {2} \nStreetAddress: {3}" +
                "\nCity: {4} \nState: {5} \nPostalCode: {6} \nNewSubscription: {7}" +
                "\nCompanyName: {8}", firstName, lastName, age, streetAddress, city, state, postalCode, newSubscription, companyName);
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n         Welcome user!");

            bool desicion = true;
            while (desicion)
            {
                Console.WriteLine("\nDo you want to read or to write a file?"
                    + "\n1)Write" + "\n2)Read");
                var userDesicion = ' ';
                try
                {
                    userDesicion = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please choose something from the menu!");
                }
                switch (userDesicion)
                {
                    //submenu for the write version starts from here.
                    case '1':
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Write");
                        Console.WriteLine("===================================");

                        bool userValue = true;
                        while (userValue)
                        {
                            Console.WriteLine("You can choose between three types of files"
                                +"   \n1)XmlFile" + "   \n2)TxtFile" + "   \n3)JsonFile", "   \n4)0 Exit the application");
                            var userwants = ' ';
                            try
                            {
                                userwants = Console.ReadLine()[0];
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Please choose something from the menu");
                            }
                            switch (userwants)
                            {
                                case '1':
                                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Xml");
                                    Console.WriteLine("================================");
                                    XmlWriter();
                                    break;
                                case '2':
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Json");
                                    Console.WriteLine("===================================");
                                    JsonWriter();
                                    break;
                                case '3':
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("XML");
                                    Console.WriteLine("===================================");
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

                        }
                        break;
                        //submenu for the read version starts from here.
                    case '2':
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
                                Console.WriteLine("Please choose something from the menu");
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
                        return;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void JsonRader()
        {
            //try
            //{
            //    string st = File.ReadAllText(@"C:\Users\User\Source\Repos\FileReader2\Filereader\Filereader\Files\json.json");
            //    Console.WriteLine(st);
            //}
            //catch (Exception m)
            //{
            //    Console.WriteLine("Sorry the file is not available at the moment to read.");
            //    Console.WriteLine(m.Message);
            //}
            //Console.Read();
            try
            {
                //Deserialize JSON from file
                String JSONstring = File.ReadAllText(@"C:\Users\User\Source\Repos\FileReader2\Filereader\Filereader\Files\json.json");

                JavaScriptSerializer ser = new JavaScriptSerializer();
                Person p1 = ser.Deserialize<Person>(JSONstring);
                Console.WriteLine(p1);
            }
            catch (Exception m)
            {
                Console.WriteLine("Sorry the file is not available at the moment to read.");
                Console.WriteLine(m.Message);
            }
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
        ///  for more advance
        ///  http://forum.codecall.net/topic/58239-c-tutorial-reading-and-writing-xml-files/
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
        static void JsonWriter()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p2 = new Person() { firstName="taleb", age=32};
            string outputJSON = ser.Serialize(p2);
            File.WriteAllText("Output.json",outputJSON);
        }
        /// <summary>
        /// http://csharp.net-informations.com/xml/csharp-xmltutorial.htm
        /// </summary>
        static void TextWriter() { }
        /// <summary>
        /// Creating a new XML file
        /// </summary>
        static void XmlWriter()
        {
            XDocument Tree = new XDocument(
                 new XDeclaration("1.0","utf-8","yes"),
                 new XComment("Creating an XML Tree using LINQ to XML"),
                 new XElement("Student",
                     new XElement("Student", new XAttribute("Id",101),
                        new XElement("Name", "Mark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", "800"))));
            Console.WriteLine(Tree);
            Console.Read();
        }   
    }
}