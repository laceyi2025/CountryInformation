using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CountryInformation
{
   public partial class CountryInformation : Form
   {
      public CountryInformation()
      {
         InitializeComponent();
      }
      /*
       * Isaiah Lacey 
       * 
       * 3/3/2020
       * 
       * Purpose: To display country information to the user
       */

      //globals
      string[] listOfCountries = new string[243];
      string[] countries = new string[243];
      string[] latitude = new string[243];
      string[] longitude = new string[243];

      private void LoadCountriesFromFile(ref string[] listToLoad)
      {
         StreamReader inputFileReader = File.OpenText("CountryInfo.csv");
         int index = 0;
         string[] dataList = new string[243];
         while (!inputFileReader.EndOfStream)
         {
            //dataList[index] = inputFileReader.ReadLine().Split(',');

           listToLoad[index] = inputFileReader.ReadLine();
            index++;
         }

      }

      private void PrintArrayContents(ref string[] arrayToPrint)
      {
         foreach (string country in arrayToPrint)
         {
            lstCountryInfo.Items.Add(country);
         }
      }

      private void CountryInformation_Load(object sender, EventArgs e)
      {
         LoadCountriesFromFile(ref listOfCountries);
         PrintArrayContents(ref listOfCountries);
      }

      private void SearchForCountryInfo()
      {
         bool countryFound = false; 

         for (int index = lstCountryInfo.Items.Count - 1; index>=0; index --)
         {
            if (lstCountryInfo.Items[index].ToString().Contains(txtSearchBar.Text))
            {
               lstCountryInfo.SetSelected(index, true);
               countryFound = true;
            }
         }

         if (countryFound)
         {
            MessageBox.Show("Is this the correct country?");

         }
         else
         {
            MessageBox.Show("No country found");
            txtSearchBar.Clear();
         }
      }

      private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
      {
         
         SearchForCountryInfo();
         if (e.KeyCode == Keys.Enter)
         {
            btnSearch.PerformClick();
         }
         else if (e.KeyCode == Keys.Delete)
         {
            btnClear.PerformClick();
         }
         

        
      }
   }
}
