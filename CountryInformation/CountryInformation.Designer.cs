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
         this.webBrowserMap.Location = new System.Drawing.Point(6, 19);
         this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
         this.webBrowserMap.Name = "webBrowserMap";
         this.webBrowserMap.ScriptErrorsSuppressed = true;
         this.webBrowserMap.Size = new System.Drawing.Size(541, 326);
         this.webBrowserMap.TabIndex = 0;
         this.webBrowserMap.Url = new System.Uri("https://www.google.com/maps/@41.082613,-85.1509,11z", System.UriKind.Absolute);
         // 
         // gbxMap
         // 
         this.gbxMap.BackColor = System.Drawing.Color.DarkBlue;
         this.gbxMap.Controls.Add(this.webBrowserMap);
         this.gbxMap.Location = new System.Drawing.Point(12, 85);
         this.gbxMap.Name = "gbxMap";
         this.gbxMap.Size = new System.Drawing.Size(555, 353);
         this.gbxMap.TabIndex = 2;
         this.gbxMap.TabStop = false;
         // 
         // lstCountryInfo
         // 
         this.lstCountryInfo.ForeColor = System.Drawing.Color.DarkBlue;
         this.lstCountryInfo.FormattingEnabled = true;
         this.lstCountryInfo.Location = new System.Drawing.Point(574, 12);
         this.lstCountryInfo.Name = "lstCountryInfo";
         this.lstCountryInfo.Size = new System.Drawing.Size(214, 355);
         this.lstCountryInfo.TabIndex = 1;
         this.lstCountryInfo.DoubleClick += new System.EventHandler(this.lstCountryInfo_DoubleClick);
         // 
         // txtSearchBar
         // 
         this.txtSearchBar.AutoCompleteCustomSource.AddRange(new string[] {
            "[countries]"});
         this.txtSearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.txtSearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
         this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSearchBar.ForeColor = System.Drawing.Color.DarkBlue;
         this.txtSearchBar.Location = new System.Drawing.Point(574, 374);
         this.txtSearchBar.Name = "txtSearchBar";
         this.txtSearchBar.Size = new System.Drawing.Size(214, 26);
         this.txtSearchBar.TabIndex = 0;
         this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
         this.txtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBar_KeyDown);
         // 
         // btnClear
         // 
         this.btnClear.BackColor = System.Drawing.Color.DarkBlue;
         this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.btnClear.Location = new System.Drawing.Point(574, 407);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(109, 31);
         this.btnClear.TabIndex = 4;
         this.btnClear.Text = "Clear";
         this.btnClear.UseVisualStyleBackColor = false;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnSearch
         // 
         this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
         this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.btnSearch.Location = new System.Drawing.Point(690, 406);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(98, 32);
         this.btnSearch.TabIndex = 5;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = false;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // txtSearchResults
         // 
         this.txtSearchResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.txtSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSearchResults.ForeColor = System.Drawing.Color.DarkBlue;
         this.txtSearchResults.Location = new System.Drawing.Point(12, 50);
         this.txtSearchResults.Name = "txtSearchResults";
         this.txtSearchResults.ReadOnly = true;
         this.txtSearchResults.Size = new System.Drawing.Size(556, 29);
         this.txtSearchResults.TabIndex = 6;
         // 
         // lblCountryInfo
         // 
         this.lblCountryInfo.BackColor = System.Drawing.Color.DarkBlue;
         this.lblCountryInfo.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCountryInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblCountryInfo.Location = new System.Drawing.Point(12, 12);
         this.lblCountryInfo.Name = "lblCountryInfo";
         this.lblCountryInfo.Size = new System.Drawing.Size(556, 35);
         this.lblCountryInfo.TabIndex = 7;
         this.lblCountryInfo.Text = "Country Information";
         this.lblCountryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // CountryInformation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BackgroundImage = global::CountryInformation.Properties.Resources.EarthBackground;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(800, 445);
         this.Controls.Add(this.lblCountryInfo);
         this.Controls.Add(this.txtSearchResults);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.txtSearchBar);
         this.Controls.Add(this.lstCountryInfo);
         this.Controls.Add(this.gbxMap);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CountryInformation";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "CountryInformation";
         this.Load += new System.EventHandler(this.CountryInformation_Load);
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

