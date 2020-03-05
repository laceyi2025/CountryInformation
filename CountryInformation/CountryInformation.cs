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

      /// <summary>
      /// Open and read the file into the program
      /// </summary>
      private void LoadCountriesFromFile()
      {
         StreamReader inputFileReader = File.OpenText("CountryInfo.csv");
         int index = 0;
         string[] dataList;

         while (!inputFileReader.EndOfStream)
         {
            dataList = inputFileReader.ReadLine().Split(',');
            countries[index] = dataList[0];
            latitude[index] = dataList[1];
            longitude[index] = dataList[2];
            index++;
         }

         inputFileReader.Close();
         inputFileReader.Dispose();

      }

      private void PrintArrayContents()
      {
         foreach (string country in countries)
         {
            lstCountryInfo.Items.Add(country);
            txtSearchBar.AutoCompleteCustomSource.Add(country);
         }
      }

      private void CountryInformation_Load(object sender, EventArgs e)
      {
         LoadCountriesFromFile();
         PrintArrayContents();
      }

      private void SearchForCountryInfo()
      {
         bool countryFound = false;
         

         for (int index = lstCountryInfo.Items.Count - 1; index >= 0; index--)
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
         if (e.KeyCode == Keys.Enter)
         {
            btnSearch.PerformClick();
         }
         else if (e.KeyCode == Keys.Delete)
         {
            btnClear.PerformClick();
         }
      }

      private void btnSearch_Click(object sender, EventArgs e)
      {
         SearchForCountryInfo();
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         txtSearchBar.Clear();
         txtSearchResults.Clear();
      }
   }
}
