using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp3
{
    static class Program
    {

        public static List<Person> PersonList = new List<Person>();
        public static List<Property> PropertyList = new List<Property>();
        public static List<House> HouseList = new List<House>();
        public static List<Apartment> ApartmentList = new List<Apartment>();
        public static List<Person> SycamorePersonList = new List<Person>();
        public static List<Apartment> SycamoreApartmentList = new List<Apartment>();
        public static List<House> SycamoreHouseList = new List<House>();
        public static List<Property> SycamorePropertyList = new List<Property>();
        public readonly static Community dekalbCommunity = new Community();
        private readonly static Community sycamoreCommunity = new Community();
        private static void FileReader(string nameOfFile, Action<string[]> lineProcessor)
        {
            using (FileStream myFile = File.OpenRead("../../" + nameOfFile))
            using (StreamReader streamReader = new StreamReader(myFile))
            {
                string inputLine;

                while ((inputLine = streamReader.ReadLine()) != null)
                {
                    if (inputLine.Length > 0)
                    {
                        string[] splicing = inputLine.Split('\t');
                        lineProcessor(splicing);
                    }
                }
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //call the file reader method to parse each file and add their information to our lists
            FileReader("p.txt", (inputFile) => { Person personFromInput = new Person(inputFile); dekalbCommunity.AddPerson(personFromInput); PersonList.Add(personFromInput); });
            FileReader("a.txt", (inputFile) => { Apartment apartmentFromInput = new Apartment(inputFile); PropertyList.Add(apartmentFromInput); ApartmentList.Add(apartmentFromInput); });
            FileReader("r.txt", (inputFile) => { House houseFromInput = new House(inputFile); PropertyList.Add(houseFromInput); HouseList.Add(houseFromInput); });
        //    FileReader("sp.txt", (inputFile) => { Person sycamorePerson = new Person(inputFile); sycamoreCommunity.AddPerson(sycamorePerson); SycamorePersonList.Add(sycamorePerson); });
        //    FileReader("sa.txt", (inputFile) => { Apartment sycamoreApartment = new Apartment(inputFile); SycamorePropertyList.Add(sycamoreApartment); SycamoreApartmentList.Add(sycamoreApartment); });
        //    FileReader("sr.txt", (inputFile) => { House sycamoreHouse = new House(inputFile); SycamorePropertyList.Add(sycamoreHouse); SycamoreHouseList.Add(sycamoreHouse); });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
