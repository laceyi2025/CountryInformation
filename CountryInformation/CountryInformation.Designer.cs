namespace CountryInformation
{
   partial class CountryInformation
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.webBrowserMap = new System.Windows.Forms.WebBrowser();
         this.gbxMap = new System.Windows.Forms.GroupBox();
         this.lstCountryInfo = new System.Windows.Forms.ListBox();
         this.txtSearchBar = new System.Windows.Forms.TextBox();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnSearch = new System.Windows.Forms.Button();
         this.txtSearchResults = new System.Windows.Forms.TextBox();
         this.lblCountryInfo = new System.Windows.Forms.Label();
         this.gbxMap.SuspendLayout();
         this.SuspendLayout();
         // 
         // webBrowserMap
         // 
         this.webBrowserMap.Location = new System.Drawing.Point(16, 45);
         this.webBrowserMap.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.webBrowserMap.MinimumSize = new System.Drawing.Size(53, 48);
         this.webBrowserMap.Name = "webBrowserMap";
         this.webBrowserMap.ScriptErrorsSuppressed = true;
         this.webBrowserMap.Size = new System.Drawing.Size(1443, 777);
         this.webBrowserMap.TabIndex = 0;
         this.webBrowserMap.Url = new System.Uri("https://www.google.com/maps/@41.082613,-85.1509,11z", System.UriKind.Absolute);
         // 
         // gbxMap
         // 
         this.gbxMap.BackColor = System.Drawing.Color.DarkBlue;
         this.gbxMap.Controls.Add(this.webBrowserMap);
         this.gbxMap.Location = new System.Drawing.Point(32, 203);
         this.gbxMap.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.gbxMap.Name = "gbxMap";
         this.gbxMap.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.gbxMap.Size = new System.Drawing.Size(1480, 842);
         this.gbxMap.TabIndex = 1;
         this.gbxMap.TabStop = false;
         // 
         // lstCountryInfo
         // 
         this.lstCountryInfo.ForeColor = System.Drawing.Color.DarkBlue;
         this.lstCountryInfo.FormattingEnabled = true;
         this.lstCountryInfo.ItemHeight = 31;
         this.lstCountryInfo.Location = new System.Drawing.Point(1531, 29);
         this.lstCountryInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.lstCountryInfo.Name = "lstCountryInfo";
         this.lstCountryInfo.Size = new System.Drawing.Size(564, 841);
         this.lstCountryInfo.TabIndex = 2;
         // 
         // txtSearchBar
         // 
         this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSearchBar.ForeColor = System.Drawing.Color.DarkBlue;
         this.txtSearchBar.Location = new System.Drawing.Point(1531, 892);
         this.txtSearchBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.txtSearchBar.Name = "txtSearchBar";
         this.txtSearchBar.Size = new System.Drawing.Size(564, 53);
         this.txtSearchBar.TabIndex = 3;
         // 
         // btnClear
         // 
         this.btnClear.BackColor = System.Drawing.Color.DarkBlue;
         this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.btnClear.Location = new System.Drawing.Point(1531, 971);
         this.btnClear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(291, 74);
         this.btnClear.TabIndex = 4;
         this.btnClear.Text = "Clear";
         this.btnClear.UseVisualStyleBackColor = false;
         // 
         // btnSearch
         // 
         this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
         this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.btnSearch.Location = new System.Drawing.Point(1840, 968);
         this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(261, 76);
         this.btnSearch.TabIndex = 5;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = false;
         // 
         // txtSearchResults
         // 
         this.txtSearchResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.txtSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSearchResults.ForeColor = System.Drawing.Color.DarkBlue;
         this.txtSearchResults.Location = new System.Drawing.Point(32, 119);
         this.txtSearchResults.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.txtSearchResults.Name = "txtSearchResults";
         this.txtSearchResults.ReadOnly = true;
         this.txtSearchResults.Size = new System.Drawing.Size(1476, 61);
         this.txtSearchResults.TabIndex = 6;
         // 
         // lblCountryInfo
         // 
         this.lblCountryInfo.BackColor = System.Drawing.Color.DarkBlue;
         this.lblCountryInfo.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountryInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblCountryInfo.Location = new System.Drawing.Point(32, 29);
         this.lblCountryInfo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
         this.lblCountryInfo.Name = "lblCountryInfo";
         this.lblCountryInfo.Size = new System.Drawing.Size(1483, 83);
         this.lblCountryInfo.TabIndex = 7;
         this.lblCountryInfo.Text = "Country Information";
         this.lblCountryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // CountryInformation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BackgroundImage = global::CountryInformation.Properties.Resources.EarthBackground;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(2133, 1073);
         this.Controls.Add(this.lblCountryInfo);
         this.Controls.Add(this.txtSearchResults);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.txtSearchBar);
         this.Controls.Add(this.lstCountryInfo);
         this.Controls.Add(this.gbxMap);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CountryInformation";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "CountryInformation";
         this.Load += new System.EventHandler(this.CountryInformation_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountryInformation_KeyDown);
         this.gbxMap.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.GroupBox gbxMap;
        private System.Windows.Forms.ListBox lstCountryInfo;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchResults;
        private System.Windows.Forms.Label lblCountryInfo;
    }
}

