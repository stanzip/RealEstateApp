using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Community[] communityArray;
        private Community selectedCommunity;
        private Dictionary<string, Property> propertyDictionary;
        #region
        public Form1()
        {
            propertyDictionary = new Dictionary<string, Property>();

            communityArray = new Community[2] { new Community(60115, "DeKalb"),
                                               new Community(60178, "Sycamore") };
            InitializeComponent();
        }

        private void DeKalbRadioBtn_Click(object sender, EventArgs e)
        {
            if (DeKalbRadioBtn.Checked)
            {
                foreach (object o in ResidenceListBox.Items)
                {
                    if (o is Property)
                    {
                        string obj = o.ToString();
                        Property property = o as Property;
                        propertyDictionary.Add(obj, property);
                        theirResidence.Items.Add(obj);
                    }
                }
                RadioButton button = sender as RadioButton;

                string s = button.Text;

                Community c = communityArray.Where(com => com.name == s).FirstOrDefault();
                PersonListBox.Items.Clear();
                ResidenceListBox.Items.Clear();
                selectedCommunity = c;

                //Type residenceType;

                foreach (Person person in Program.PersonList)
               {
                    PersonListBox.Items.Add(person.basicInfo());
               }

                //if (residenceType == typeof(House))
                
                    foreach (House house in Program.HouseList)
                    {
                        ResidenceListBox.Items.Add(house.basicPropertyInfo());
                    }
                


                 foreach (Apartment apartment in Program.ApartmentList)
                {
                    ResidenceListBox.Items.Add(apartment.apartmentPropertyInfo());
                }
                OutputArea.Text = "The residents and properties of DeKalb are now listed.";
            }
            //else if (SycamoreRadioBtn.Checked)
            //{
              //  PersonListBox.Items.Clear();
                //ResidenceListBox.Items.Clear();

           //     foreach(Person person in Program.SycamorePersonList)
             //   {
              //      PersonListBox.Items.Add(person);
               // }

               // foreach(Property property in Program.SycamorePropertyList)
               // {
                //    ResidenceListBox.Items.Add(property);
               // }
            //}

        }
        #endregion

        private void SycamoreRadioBtn_Click(object sender, EventArgs e)
        {
            if (SycamoreRadioBtn.Checked)
            {
                PersonListBox.Items.Clear();
                ResidenceListBox.Items.Clear();

                OutputArea.Text = "The residents and properties of Sycamore are now listed.";
            }
        }

        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = PersonListBox.SelectedItem;

            Property propertySelection = selectedItem as Property;


            //selectedItem = person.ToString();
            OutputArea.Text = $"{selectedItem}, who resides at: ";
            
          /*  foreach(uint id in propertySelection.ResidenceIDs)
            {
                Property property = selectedCommunity.Properties.Where(p => p.id == id).FirstOrDefault();
                OutputArea.Text = $"\t{property.streetAddr}";
            }*/

           foreach(Property p in Program.PropertyList)
           {
            propertySelection = p;
            OutputArea.Text = selectedItem + " who resides at: " + p.streetAddr;    
           }

        }

        private void ToggleForSaleBtn_Click(object sender, EventArgs e)
        {
            if (ResidenceListBox.SelectedIndex != -1)
            {
                var theSelectedProperty = ResidenceListBox.SelectedItem.ToString();
                OutputArea.Text = theSelectedProperty + " is now for sale!";
            }
            else
            {
                OutputArea.Text = 
                "You need to select a property from the list of residences to use this button!";
            }
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (PersonListBox.SelectedIndex != -1 && ResidenceListBox.SelectedIndex != -1)
            { 
                var theChosenProperty = ResidenceListBox.SelectedItem.ToString();
                var theChosenOne = PersonListBox.SelectedItem.ToString();
                int personStringIndex = theChosenOne.IndexOf(" ");
                int propertyStringIndex = theChosenProperty.IndexOf("*");
                var regexItem = new Regex("[*]");

                    if(regexItem.IsMatch(theChosenProperty))
                    {

                    OutputArea.Text = "Success! " + theChosenOne.Substring(0,personStringIndex) 
                    + " has purchased the property at " 
                    + theChosenProperty.Substring(0,propertyStringIndex);

                     }


                    else if (!regexItem.IsMatch(theChosenProperty))
                    {

                    OutputArea.Text = "That property is NOT for Sale";
                    
                    }
            }

            else
            {
                OutputArea.Text = 
                "You need to select an option from both the person and residence field in order " +
                "to buy a property.";
            }
        }

        private void ResidenceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ResidenceListBox.SelectedItem.ToString();

            foreach (Property p in Program.PropertyList)

           {
              string owner = p.OwnerInfo(Program.dekalbCommunity);
                OutputArea.Text = "Residents living at " + p.streetAddr + " owned by " + p.ownerID;
           }
        }

        private void AddResidentBtn_Click(object sender, EventArgs e)
        {
            if (PersonListBox.SelectedIndex != -1 && ResidenceListBox.SelectedIndex != -1)
            {
                var selectedResident = PersonListBox.SelectedItem.ToString();
                var selectedProperty = ResidenceListBox.SelectedItem.ToString();

                int personStringIndex = selectedResident.IndexOf(" ");
                int propertyStringIndex = selectedProperty.IndexOf("*");

               OutputArea.Text = "Success! " + selectedResident.Substring(0, personStringIndex)
               + " now resides at the property of "
               + selectedProperty.Substring(0, propertyStringIndex);

              //  Person person = selectedResident as Person;
               // AddPerson(person);

            }

            else
            {
                OutputArea.Text = "You need to select a resident and a residence to successfully click this button!";
            }
         }
        private void RemoveResidentBtn_Click(object sender, EventArgs e)
        {
           if (PersonListBox.SelectedIndex != -1 && ResidenceListBox.SelectedIndex != -1)
            {
                var residentToRemove = PersonListBox.SelectedItem.ToString();
                var fromThisResidence = ResidenceListBox.SelectedItem.ToString();

                int personStringIndex = residentToRemove.IndexOf(" ");
                int propertyStringIndex = fromThisResidence.IndexOf("*");

                OutputArea.Text = "Success! " + residentToRemove.Substring(0, personStringIndex)
                + " no longer resides at the property of "
                + fromThisResidence.Substring(0, propertyStringIndex);

            }

            else
            {
                OutputArea.Text = "You need to select a resident and a residence to successfully click this button!";
            }
        }

        private void NewResidentBtn_Click(object sender, EventArgs e)
        {
           /* OutputArea.Clear();

            string newResidentName = newResident.Text;
            string newResidentOccupation = theirOccupation.Text;
            DateTime newResidentBirthday = theirBirthday.Value;
            string newResidentID = theirResidence.Text;

            if (newResidentName.Length == 0)
            {
                OutputArea.Text = "You have not entered a name.";
            }

            if (newResidentOccupation.Length == 0)
            {
                OutputArea.Text = "You have not entered an occupation.";
            }

            if (newResidentID.Length == 0)
            {
                OutputArea.Text = "You have not selected a residence";
            }

            uint identificationNumber = selectedCommunity.residents.LastOrDefault().id + 1;

            Property property = propertyDictionary[newResidentID];
            Person person = new Person(identificationNumber, newResidentName, newResidentOccupation, newResidentBirthday, property.id);

            if(!selectedCommunity.AddPerson(person))
            {
                OutputArea.Text = "Unable to add this resident.";
            }

            else
            {
                PersonListBox.Items.Add(person);
                Program.PersonList.Add(person);

                OutputArea.Text = $"Success! {person.firstName} has been added as a resident to {selectedCommunity.name}!";
            }*/
        }
    }
}
