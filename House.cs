//Class definition for another type of residence - a house that inherits the residential class

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3
{
    public class House : Residential
    {
        //private variables
        private bool garage;
        private bool? attachedGarage;
        private uint floors;

        //accessor methods for private variables
        public bool Garage
        {
            get { return garage; }
            set { Garage = value; }
        }

        public bool? AttachedGarage
        {
            get { return attachedGarage; }
            set { AttachedGarage = value; }
        }

        public uint Floors
        {
            get { return floors; }
            set { Floors = value; }
        }

        public House() : base()
        {
            floors = 0;
            garage = false;
            attachedGarage = null;

        }

        //another implementation of the residence info method for when we have to display what type of garage the house has
        protected override void residenceInfo()
        {
            base.residenceInfo();

            string garageOrNot = "no garage";

            if (garage && attachedGarage.Value)
            {
                garageOrNot = "an attached garage";
            }

            else if (garage)
            {
                garageOrNot = "a detached garage";
            }

            string flooring = "floor";

            if (floors > 1)
            {
                flooring += 's';
            }

            Console.WriteLine($"\n\t ...with {garageOrNot} : {floors} {flooring}.");
        }

        //another class constructor method that will take file input as it's argument and parse corresponding fields
        public House(string[] input) : base(input)
        {
            garage = boolParser();
            attachedGarage = boolParser();
            floors = uintParser();

            if (!garage)
            {
                attachedGarage = null;
            }
        }
    }
}