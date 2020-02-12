//final class of Community which implements both the IComparable and IEnumerable interfaces which allows us to compare objects
//and iterate through lists of people
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3

{
    public class Community : IComparable, IEnumerable<Person>
    {
        //class attributes
        private SortedSet<Property> props = new SortedSet<Property>();
        private SortedSet<Person> residents = new SortedSet<Person>();
        private readonly uint id;
        public string name;
        private uint mayorId;

        //an accessor method that gives us the amount of residents in the community and assigns it to population
        public int Population
        { get { return residents.Count; } }


        //cast our sorted set objects as lists
        public List<Property> Properties => props.ToList();
        public List<Person> Residents => residents.ToList();

        //default constructor
        public Community()
        {
            id = 0;
            name = "";
            mayorId = 0;
        }

        //secondary constructor that takes all arguments and defines values for them
        public Community(SortedSet<Property> properties, SortedSet<Person> people, uint ID, string communityName, uint MayorID)
        {
            props = properties;
            residents = people;
            ID = 99999;
            MayorID = 0;
            communityName = "DeKalb";
        }

        public Community(uint id, string name, uint mayorId = 0)
        {
            this.id = id;
            this.name = name;
            this.mayorId = mayorId;
        }

        //implement the CompareTo method in a way that will sort the communities by name. Takes an object argument to typecast as
        //a community object
        public int CompareTo(object alpha)
        {
            if (alpha == null)
            { throw new ArgumentNullException(); }

            Community rightOperand = alpha as Community; //typecast our object as a Community object

            if (rightOperand != null)
            { return name.CompareTo(rightOperand.name); }

            else
            { throw new ArgumentException("[Community]:CompareTo argument is not a Community"); }

        }

        //prototype
        IEnumerator<Person> IEnumerable<Person>.GetEnumerator()
        { return residents.GetEnumerator(); }

        //implementation of getEnumerator that will allow us to iterate through the list
        public IEnumerator<Person> GetEnumerator()
        { return residents.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator() { return this.GetEnumerator(); }


        //Method AddProperty, takes a property object as an argument. Will add a property object to our list of properties
        public bool AddProperty(Property property)
        {
            return props.Add(property);
        }

        //Method AddPerson, takes a person object as an argument. Will add a person object to our list of people.
        public bool AddPerson(Person person)
        {
            return residents.Add(person);
        }
    }
}