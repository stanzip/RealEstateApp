using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp3
{

    public abstract class Property : IComparable
    {

        public uint id;
        public uint ownerID;
        public uint x;
        public uint y;
        public string streetAddr;
        public string city;
        public string state;
        public string zip;
        public bool forSale;
        private string[] propertiesInput;
        private int index;

        public string forSaleOrNot => (forSale ? "FOR SALE" : "NOT for sale");

        protected abstract void residenceInfo();
        protected string stringParser() => propertiesInput[index++];
        protected bool boolParser() => (stringParser() == "T");
        protected uint uintParser() => uint.Parse(stringParser());
        protected uint binaryParser() => Convert.ToUInt32(stringParser(), 2);
        public Property()
        {
            id = 0;
            ownerID = 0;
            x = 0;
            y = 0;
            streetAddr = "";
            city = "";
            state = "";
            zip = "";
            forSale = false;
        }

        public Property(uint Id, uint OwnerID, uint X, uint Y, string StreetAddr, string City, string State, string Zip, bool ForSale)
        {
            id = Id;
            ownerID = OwnerID;
            x = X;
            y = Y;
            streetAddr = StreetAddr;
            city = City;
            state = State;
            zip = Zip;
            forSale = ForSale;
        }

        public Property(string[] input)
        {
            propertiesInput = input;

            id = uintParser();
            ownerID = binaryParser();
            x = uintParser();
            y = uintParser();
            streetAddr = stringParser();
            city = stringParser();
            state = stringParser();
            zip = stringParser();
            forSale = boolParser();

        }
        public int CompareTo(Object alpha)
        {
            if (alpha == null) throw new ArgumentNullException();
            Property rightOperand = alpha as Property;
            if (rightOperand != null)
            {
                if (state.CompareTo(rightOperand.state) == 0)
                {
                    if (city.CompareTo(rightOperand.city) == 0)
                    {
                        string fulladdress = rightOperand.streetAddr;
                        string streetNum = fulladdress.Substring(0, fulladdress.IndexOf(" "));
                        string nameStreet = fulladdress.Substring(fulladdress.IndexOf(" ") + 1);
                        string compName = streetAddr.Substring(streetAddr.IndexOf(" ") + 1);
                        string compNum = streetAddr.Substring(0, streetAddr.IndexOf(" "));
                        //return streetAddr.CompareTo(rightOperand.streetAddr);
                    }
                    return city.CompareTo(rightOperand.city);

                }
                return state.CompareTo(rightOperand.state);
            }
            else
                throw new ArgumentException("[Property]:CompareTo argument is not a Property");

        }

        public override string ToString()
        { return $"{streetAddr}, {city}, {state}, {zip}"; }

        public void PropertyInfo(Community c)
        {
            Console.WriteLine($"Property Address: {streetAddr} / {city} / {state} / {zip}");
            Person owner = c.Residents.Where(person => person.id == ownerID).FirstOrDefault();
            Console.WriteLine($"\tOwned by {owner}");
            Console.Write($"\t({forSaleOrNot}) ");
            residenceInfo();
        }

        public string OwnerInfo(Community c)
        {
            Person owner = c.Residents.Where(person => person.id == ownerID).FirstOrDefault();
            return "{owner}";
            //Console.Write("{owner}");
        }
        public string basicPropertyInfo()
        {
            if (forSale == true)
            {
               // forSaleOrNot = "*";
                return $"{streetAddr} *";
            }
            else
                return $"{streetAddr}";

        }

    }
}