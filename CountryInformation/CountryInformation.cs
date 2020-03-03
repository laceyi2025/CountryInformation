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

      string[] listOfCountries = new string[244];

      private void LoadCountriesFromFile(string[] listToLoad)
      {
         StreamReader inputFileReader = File.OpenText("CountryInfo.csv");
         int index = 0;
         while (!inputFileReader.EndOfStream)
         {
            listToLoad[index] = inputFileReader.ReadLine();

            index++;
         }
         inputFileReader.Close();
      }

      private void PrintArrayContents(string[] arrayToPrint)
      {
         foreach (string country in arrayToPrint)
         {
            lstCountryInfo.Items.Add(country);
         }
      }

      private void CountryInformation_Load(object sender, EventArgs e)
      {
         LoadCountriesFromFile(listOfCountries);
         PrintArrayContents(listOfCountries);
      }

      private void btnSearch_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnSearch.PerformClick();
         }
      }
      private void SearchForCountryInfo()
      {
         
      }
   }
}
