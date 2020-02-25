using System;

namespace Assign3
{
    public class Business : Property

    {
        string name;
        readonly enum BusinessType { Grocery, Bank, Repair, FastFood, DepartmentStore }
        readonly string yearEstablished;
        uint activeRecruitment;

        public Business() : base()
            {
            name = "";
            yearEstablished = "";
            activeRecruitment = 0;
            }

        public Business(string[] input) : base(input)
        {
            name = stringParser();
            yearEstablished = stringParser();
            activeRecruitment = uintParser();
        }

        public override ToString()
        {
            return $"{name}, a {BusinessType} type of business, established in {yearEstablished}";
        }

}
}
