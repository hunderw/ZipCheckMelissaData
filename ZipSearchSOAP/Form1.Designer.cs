namespace ZipSearchSOAP
{
    partial class Form1
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
            this.XMLView = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ZipSearchView = new System.Windows.Forms.TabPage();
            this.txtResults = new System.Windows.Forms.Label();
            this.RdoBtnCityInState = new System.Windows.Forms.RadioButton();
            this.RdoBtnZipInCity = new System.Windows.Forms.RadioButton();
            this.RdoBtnCityInZip = new System.Windows.Forms.RadioButton();
            this.checkOfficial = new System.Windows.Forms.CheckBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.DoZipSearch = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.XMLView.SuspendLayout();
            this.ZipSearchView.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLView
            // 
            this.XMLView.Controls.Add(this.webBrowser2);
            this.XMLView.Controls.Add(this.webBrowser1);
            this.XMLView.Location = new System.Drawing.Point(4, 22);
            this.XMLView.Name = "XMLView";
            this.XMLView.Padding = new System.Windows.Forms.Padding(3);
            this.XMLView.Size = new System.Drawing.Size(786, 317);
            this.XMLView.TabIndex = 1;
            this.XMLView.Text = "XML View";
            this.XMLView.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(780, 311);
            this.webBrowser2.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(780, 311);
            this.webBrowser1.TabIndex = 0;
            // 
            // ZipSearchView
            // 
            this.ZipSearchView.Controls.Add(this.label1);
            this.ZipSearchView.Controls.Add(this.txtResults);
            this.ZipSearchView.Controls.Add(this.RdoBtnCityInState);
            this.ZipSearchView.Controls.Add(this.RdoBtnZipInCity);
            this.ZipSearchView.Controls.Add(this.RdoBtnCityInZip);
            this.ZipSearchView.Controls.Add(this.checkOfficial);
            this.ZipSearchView.Controls.Add(this.txtCountry);
            this.ZipSearchView.Controls.Add(this.txtZip);
            this.ZipSearchView.Controls.Add(this.txtState);
            this.ZipSearchView.Controls.Add(this.txtCity);
            this.ZipSearchView.Controls.Add(this.txtCustomerID);
            this.ZipSearchView.Controls.Add(this.Country);
            this.ZipSearchView.Controls.Add(this.Zip);
            this.ZipSearchView.Controls.Add(this.State);
            this.ZipSearchView.Controls.Add(this.City);
            this.ZipSearchView.Controls.Add(this.DoZipSearch);
            this.ZipSearchView.Controls.Add(this.CustomerID);
            this.ZipSearchView.Location = new System.Drawing.Point(4, 22);
            this.ZipSearchView.Name = "ZipSearchView";
            this.ZipSearchView.Padding = new System.Windows.Forms.Padding(3);
            this.ZipSearchView.Size = new System.Drawing.Size(620, 316);
            this.ZipSearchView.TabIndex = 0;
            this.ZipSearchView.Text = "Zip Search View";
            this.ZipSearchView.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.AutoSize = true;
            this.txtResults.Location = new System.Drawing.Point(507, 271);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(45, 13);
            this.txtResults.TabIndex = 15;
            this.txtResults.Text = "Results:";
            // 
            // RdoBtnCityInState
            // 
            this.RdoBtnCityInState.AutoSize = true;
            this.RdoBtnCityInState.Location = new System.Drawing.Point(275, 218);
            this.RdoBtnCityInState.Name = "RdoBtnCityInState";
            this.RdoBtnCityInState.Size = new System.Drawing.Size(168, 17);
            this.RdoBtnCityInState.TabIndex = 14;
            this.RdoBtnCityInState.TabStop = true;
            this.RdoBtnCityInState.Text = "Find the City names in a State.";
            this.RdoBtnCityInState.UseVisualStyleBackColor = true;
            // 
            // RdoBtnZipInCity
            // 
            this.RdoBtnZipInCity.AutoSize = true;
            this.RdoBtnZipInCity.Location = new System.Drawing.Point(275, 195);
            this.RdoBtnZipInCity.Name = "RdoBtnZipInCity";
            this.RdoBtnZipInCity.Size = new System.Drawing.Size(157, 17);
            this.RdoBtnZipInCity.TabIndex = 13;
            this.RdoBtnZipInCity.TabStop = true;
            this.RdoBtnZipInCity.Text = "Find the Zip Codes in a City.";
            this.RdoBtnZipInCity.UseVisualStyleBackColor = true;
            // 
            // RdoBtnCityInZip
            // 
            this.RdoBtnCityInZip.AutoSize = true;
            this.RdoBtnCityInZip.Location = new System.Drawing.Point(275, 172);
            this.RdoBtnCityInZip.Name = "RdoBtnCityInZip";
            this.RdoBtnCityInZip.Size = new System.Drawing.Size(160, 17);
            this.RdoBtnCityInZip.TabIndex = 12;
            this.RdoBtnCityInZip.TabStop = true;
            this.RdoBtnCityInZip.Text = "Find the Cities in a Zip Code.";
            this.RdoBtnCityInZip.UseVisualStyleBackColor = true;
            // 
            // checkOfficial
            // 
            this.checkOfficial.AutoSize = true;
            this.checkOfficial.Location = new System.Drawing.Point(253, 142);
            this.checkOfficial.Name = "checkOfficial";
            this.checkOfficial.Size = new System.Drawing.Size(272, 17);
            this.checkOfficial.TabIndex = 11;
            this.checkOfficial.Text = "Check, only if you want the record of the official city.";
            this.checkOfficial.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(100, 264);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(100, 205);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(62, 20);
            this.txtZip.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(100, 234);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(33, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(100, 173);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(100, 140);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.Text = "106223395";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(48, 267);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(46, 13);
            this.Country.TabIndex = 9;
            this.Country.Text = "Country:";
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(59, 208);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(25, 13);
            this.Zip.TabIndex = 7;
            this.Zip.Text = "Zip:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(54, 241);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(38, 13);
            this.State.TabIndex = 5;
            this.State.Text = "State: ";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(59, 176);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(27, 13);
            this.City.TabIndex = 3;
            this.City.Text = "City:";
            // 
            // DoZipSearch
            // 
            this.DoZipSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZipSearchSOAP.Properties.Settings.Default, "txtResults", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoZipSearch.Location = new System.Drawing.Point(510, 236);
            this.DoZipSearch.Name = "DoZipSearch";
            this.DoZipSearch.Size = new System.Drawing.Size(75, 23);
            this.DoZipSearch.TabIndex = 2;
            this.DoZipSearch.Text = global::ZipSearchSOAP.Properties.Settings.Default.txtResults;
            this.DoZipSearch.UseVisualStyleBackColor = true;
            this.DoZipSearch.Click += new System.EventHandler(this.DoZipSearch_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(24, 144);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(68, 13);
            this.CustomerID.TabIndex = 0;
            this.CustomerID.Text = "Customer ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ZipSearchView);
            this.tabControl1.Controls.Add(this.XMLView);
            this.tabControl1.Location = new System.Drawing.Point(31, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(152, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Melissa Data Zip Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.XMLView.ResumeLayout(false);
            this.ZipSearchView.ResumeLayout(false);
            this.ZipSearchView.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage XMLView;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage ZipSearchView;
        private System.Windows.Forms.Label txtResults;
        private System.Windows.Forms.RadioButton RdoBtnCityInState;
        private System.Windows.Forms.RadioButton RdoBtnZipInCity;
        private System.Windows.Forms.RadioButton RdoBtnCityInZip;
        private System.Windows.Forms.CheckBox checkOfficial;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button DoZipSearch;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;



    }
}

