using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        #region
        public Form1()
        {
            InitializeComponent();
        }

        private void DeKalbRadioBtn_Click(object sender, EventArgs e)
        {
            if (DeKalbRadioBtn.Checked)
            {
                PersonListBox.Items.Clear();
                ResidenceListBox.Items.Clear();

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
            var selectedItem = PersonListBox.SelectedItem;
            
           // OutputArea.Text = selectedItem + " who resides at: ";
            
            foreach(var property in Program.PropertyList)
            {
                    //property.PropertyInfo(Program.dekalbCommunity);
                    OutputArea.Text = selectedItem + " who resides at: " + property.streetAddr;
                
            }
        }

        private void ToggleForSaleBtn_Click(object sender, EventArgs e)
        {
            if(ResidenceListBox.SelectedIndex != -1)
           {
                //ResidenceListBox.SelectedIndex += 1;
                Property theSelectedProperty = ResidenceListBox.SelectedValue as Property;
                

                foreach(Property property in Program.PropertyList)
                {
                   theSelectedProperty = property;
                
                    if (property.forSale == true)
                    {
                        property.forSale = false;
                        OutputArea.Text = property.streetAddr + " is now for sale!";
                    }
                    else if (property.forSale == false)
                    {
                       property.forSale = true;
                    }
                 }
            }
            else
            {
              OutputArea.Text = "You need to select a residence to toggle for sale/not for sale.";
            }
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (PersonListBox.SelectedIndex != -1 && ResidenceListBox.SelectedIndex != -1)
            {
                Property propertySelected = ResidenceListBox.SelectedItem as Property;
                Person personSelection = PersonListBox.SelectedItem as Person;

                foreach (Property p in Program.PropertyList)
                {
                    propertySelected = p;

                    if (p.forSale == false)
                    {
                        OutputArea.Text = "That property is NOT for Sale";
                    }

                    else if (p.forSale == true)
                    {
                        foreach (Person person in Program.PersonList)
                        { personSelection = person;  }
                        OutputArea.Text = "Success! " + personSelection.firstName + " has purchased the property at " + p.streetAddr;
                    }
                }
            }
        }

        private void ResidenceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ResidenceListBox.SelectedItem;

            foreach (Property p in Program.PropertyList)

            {
                string owner = p.OwnerInfo(Program.dekalbCommunity);
                OutputArea.Text = "Residents living at " + p.streetAddr + " owned by " + owner;
            }
        }
    }
}