//Class definition of apartment which is a type of residence and therefore inherits the residential class

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3
{
    public class Apartment : Residential
    {
        //a single private attribute
        private string unit;

        //accessor method for the unit string
        public string Unit
        {
            get { return unit; }
            set { Unit = value; }
        }

        //default constructor
        public Apartment() : base()
        {
            unit = "";
        }

        //secondary constructor that will parse string input from file input and place it in our unit variable
        public Apartment(string[] input) : base(input)
        {
            unit = stringParser();
        }

        //override and implement a new residence info method that will output the unit string attached to apartments
        //Takes no arguments
        protected override void residenceInfo()
        {
            base.residenceInfo();
            Console.WriteLine($" Apt.# {Unit}");
        }
        public string apartmentPropertyInfo()
        {
            if (forSale == true)
            {
                // forSaleOrNot = "*";
                return $"{streetAddr} #{unit} *";
            }
            else
                return $"{streetAddr} #{unit}";

        }
    }
}