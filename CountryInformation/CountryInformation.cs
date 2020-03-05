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

      /// <summary>
      /// Prints array contents to the list box
      /// </summary>
      private void PrintArrayContents()
      {
         foreach (string country in countries)
         {
            lstCountryInfo.Items.Add(country);
            txtSearchBar.AutoCompleteCustomSource.Add(country);
         }
      }

      /// <summary>
      /// loads everything to the form upon form load
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void CountryInformation_Load(object sender, EventArgs e)
      {
         gbxMap.Enabled = false;
         LoadCountriesFromFile();
         PrintArrayContents();
      }

      /// <summary>
      /// Searches for user input in the country list and displays message box to check if the contry is correct 
      /// </summary>
      private void SearchForCountryInfo()
      {
         bool countryFound = false;
         for (int index = lstCountryInfo.Items.Count - 1; index >= 0; index--)
         {
            if (lstCountryInfo.Items[index].ToString().Contains(txtSearchBar.Text))
            {
               lstCountryInfo.SetSelected(index, true);
               DialogResult dialogResult = MessageBox.Show("Is this the correct country?", "Serach Reults", MessageBoxButtons.YesNo);

               if (dialogResult == DialogResult.Yes)
               {
                  txtSearchResults.Text = ("Latitude: " + latitude[lstCountryInfo.SelectedIndex] + ", Longitude: " + longitude[lstCountryInfo.SelectedIndex]);
                  btnSearch.Enabled = false;
                  countryFound = true;
                  webBrowserMap.Navigate("http://google.com/maps/search/" + lstCountryInfo.SelectedItem.ToString());
                  break;
               }
            }
         }

         if (!countryFound)
         {
            MessageBox.Show("No country found");
            txtSearchBar.Clear();
         }
      }

      /// <summary>
      /// allows the user to hit enter to search and backspace to delete without a mouse click
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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

      /// <summary>
      /// performs a search when button is clicked
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSearch_Click(object sender, EventArgs e)
      {
         SearchForCountryInfo();
      }

      /// <summary>
      /// Clears the text box upon button click
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnClear_Click(object sender, EventArgs e)
      {
         txtSearchBar.Clear();
         txtSearchResults.Clear();
         btnSearch.Enabled = true;
      }

      /// <summary>
      /// displays coordinates upon double click of an item in the list box
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void lstCountryInfo_DoubleClick(object sender, EventArgs e)
      {
         btnSearch.Enabled = true;
         if (lstCountryInfo.SelectedIndex != null)
         {
            string url = lstCountryInfo.SelectedItem.ToString();
            webBrowserMap.Navigate("http://google.com/maps/search/" + lstCountryInfo.SelectedItem.ToString());
            txtSearchResults.Text = ("Latitude: " + latitude[lstCountryInfo.SelectedIndex] + "; Longitude: " + longitude[lstCountryInfo.SelectedIndex]);
         }
      }

      /// <summary>
      /// clears the textboxes upon entering the text field and enables search button 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void txtSearchBar_Click(object sender, EventArgs e)
      {
         txtSearchBar.Text = null;
         txtSearchResults.Text = null;
         btnSearch.Enabled = true;
         webBrowserMap.Navigate("http://google.com/maps/search/");
      }
   }
}
