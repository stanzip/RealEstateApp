using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3
{
    public class Person : IComparable
    {
        //private variable declarations
        public uint id;
        private string lastName;
        public string firstName;
        private string occupation;
        public DateTime birthday;
        private List<uint> residenceIds = new List<uint>();
        private string fullName;

        private string[] personInput;
        private int personIndex;
        protected string stringParser() => personInput[personIndex];
        protected bool boolParser() => (stringParser() == "T");
        protected uint uintParser() => uint.Parse(stringParser());
        protected uint binaryParser() => Convert.ToUInt32(stringParser(), 2);
        protected int intParser() => int.Parse(stringParser());

        //public get and set methods to access the private variables
        public uint ID
        {
            get { return id; }
            set { }
        }
        public string lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        public DateTime Birthday
        {
            get { return DateTime.Now; }
            set { }
        }
        public uint[] ResidenceIDs
        {
            get { return residenceIds.ToArray(); }
            set { }
        }

        public string FullName
        { get { return lastName + ", " + firstName; } }

        public int Age
        {
            get
            {
                TimeSpan yearsAlive = DateTime.Now - birthday;
                return (int)(yearsAlive.TotalDays / 365.2422);
            }
        }

        //Constructors
        public Person()
        {
            id = 0;
            lastName = "";
            firstName = "";
            occupation = "";
            birthday = DateTime.Now;
        }
        public Person(uint newId, string newFirstName, string newLastName, string newOccupation, DateTime newBirthday, List<uint> newResidenceID)
        {
            id = newId;
            lastName = newLastName;
            firstName = newFirstName;
            lastName = newLastName;
            occupation = newOccupation;
            birthday = newBirthday;
            residenceIds = newResidenceID;
        }


        public Person(string[] input)
        {
            id = Convert.ToUInt32(input[0], 2);
            lastName = input[1];
            firstName = input[2];
            occupation = input[3];
            int year = int.Parse(input[4]);
            int month = int.Parse(input[5]);
            int day = int.Parse(input[6]);
            //birthday = new DateTime(year, month, day);
            uint residenceId = uint.Parse(input[7]);

            birthday = new DateTime(year, month, day);
            residenceIds.Add(residenceId);
        }

        public int CompareTo(object alpha)
        {
            if (alpha == null)
            { throw new ArgumentNullException(); }// Always... check for null values

            Person rightOperand = alpha as Person; // Oo, typecasting using English! I like it

            if (rightOperand != null) // Protect against a failed typecasting
            { return FullName.CompareTo(rightOperand.FullName); }
            // Making use of what's already available!
            else
            { throw new ArgumentException("[Person]:CompareTo argument is not a Person"); }
        }



        public override string ToString()
        {
            return $"{FullName}, Age: {Age}, Occupation: {Occupation}";
        }
            

        public string basicInfo()
        {
            return $"{firstName} ({Age}) {Occupation}";
        }


    }
}
