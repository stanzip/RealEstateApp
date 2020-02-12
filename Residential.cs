//Residential class inherits the property class

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3
{
    public class Residential : Property
    {
        //all residential properties will have these attributes
        public uint bedrooms;
        public uint baths;
        public uint sqft;

        //default constructor will also take on the attributes of the base Property class
        public Residential() : base()
        {
            bedrooms = 0;
            baths = 0;
            sqft = 0;
        }

        //secondary constructor that will be able to parse file input
        public Residential(string[] fileInput) : base(fileInput)
        {
            bedrooms = uintParser();
            baths = uintParser();
            sqft = uintParser();
        }
        public uint Bedrooms
        {
            get { return bedrooms; }
            set { Bedrooms = value; }
        }
        public uint Baths
        {
            get { return baths; }
            set { Baths = value; }
        }
        public uint SqFootage
        {
            get { return sqft; }
            set { SqFootage = value; }
        }

        //implementation of the residence information method that will give us 
        protected override void residenceInfo()
        {
            Console.Write($"{bedrooms} bedrooms \\ {baths} baths \\ {sqft} sq.ft.");
        }

    }
}