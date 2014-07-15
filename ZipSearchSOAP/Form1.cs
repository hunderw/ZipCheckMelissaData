using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace ZipSearchSOAP
{
    public partial class Form1 : Form
    {
        dqwsZipSearch.Request ReqZS = new dqwsZipSearch.Request();
        dqwsZipSearch.ResponseArray ResZS = new dqwsZipSearch.ResponseArray();
        dqwsZipSearch.ServiceClient ZSClient = new dqwsZipSearch.ServiceClient();

        XmlSerializer XmlSer;
        FileStream fs;

        public Form1()
        {
            InitializeComponent();
        }

        private void DoZipSearch_Click(object sender, EventArgs e)
        {
            // Clear the XML each time
            webBrowser1.Navigate("about:blank");
            webBrowser2.Navigate("about:blank");

            // Input fields for a current record (Elements of the ZS Request)
            ReqZS = new dqwsZipSearch.Request();
            ReqZS.CustomerID = txtCustomerID.Text;
            ReqZS.TransmissionReference = "Testing SOAP Request.";
            ReqZS.City = txtCity.Text;
            ReqZS.State = txtState.Text;
            ReqZS.Zip = txtZip.Text;
            ReqZS.Country = txtCountry.Text;

            if (checkOfficial.Checked)
                ReqZS.OptOfficialCityNameOnly = "true";
            else
                ReqZS.OptOfficialCityNameOnly = "false";

            if (RdoBtnCityInZip.Checked)
                ReqZS.SearchType = "1";
            else if (RdoBtnZipInCity.Checked)
                ReqZS.SearchType = "2";
            else if (RdoBtnCityInState.Checked)
                ReqZS.SearchType = "3";

            ZSClient = new ZipSearchSOAP.dqwsZipSearch.ServiceClient();

            try
            {
                // Store results in response
                ResZS = ZSClient.doZipSearch(ReqZS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return;
            }

            // Create an XML Serializer 
            XmlSer = new XmlSerializer(ResZS.GetType());

            // Read an XML Filestream and then output it to webBrowser2
            fs = new FileStream((System.Environment.CurrentDirectory + "\\Response.xml"), FileMode.Create);
            XmlSer.Serialize(fs, ResZS);
            fs.Close();
            webBrowser2.Navigate(System.Environment.CurrentDirectory + "\\Response.xml");

            // Create and XML Serializer
            XmlSer = new XmlSerializer(ReqZS.GetType());

            // Read an XML Filestream and then output it to webBrowser1
            fs = new FileStream((System.Environment.CurrentDirectory + "\\Request.xml"), FileMode.Create);
            XmlSer.Serialize(fs, ReqZS);
            fs.Close();
            webBrowser1.Navigate(System.Environment.CurrentDirectory + "\\Request.xml");

            PopulateFieldsZS();

        }

        // Functions to populate the ZS Data Grid
        private void PopulateFieldsZS()
        {
            // Create a DataSet
            DataSet myDataSet = new DataSet("myDataSet");

            // Create two DataTables
            DataTable tblRes = new DataTable("Results");

            // Initialize Column Headers (elements of the ZS Response)
            DataColumn cRecordID = new DataColumn("Record ID");
            DataColumn cZip = new DataColumn("Zip");
            DataColumn cZipType = new DataColumn("Zip Type");
            DataColumn cTimeZoneName = new DataColumn("TimeZone Name");
            DataColumn cTimeZoneCode = new DataColumn("TimeZone Code");
            DataColumn cAreaCode = new DataColumn("Area Code");
            DataColumn cLatitude = new DataColumn("Latitude");
            DataColumn cLongitude = new DataColumn("Longitude");
            DataColumn cCityName = new DataColumn("City Name");
            DataColumn cCityAbbreviation = new DataColumn("City Abbreviation");
            DataColumn cCountyName = new DataColumn("County Name");
            DataColumn cCountyFIPS = new DataColumn("County FIPS");
            DataColumn cState = new DataColumn("State");
            DataColumn cFacilityCode = new DataColumn("Facility Code");
            DataColumn cLastLineIndicator = new DataColumn("LastLine Indicator");
            DataColumn cLastLineNumber = new DataColumn("LastLine Number");
            DataColumn cPreferredLastLineNumber = new DataColumn("Preferred LastLine Number");

            // Add column headers
            tblRes.Columns.Add(cRecordID);
            tblRes.Columns.Add(cZip);
            tblRes.Columns.Add(cZipType);
            tblRes.Columns.Add(cTimeZoneName);
            tblRes.Columns.Add(cTimeZoneCode);
            tblRes.Columns.Add(cAreaCode);
            tblRes.Columns.Add(cLatitude);
            tblRes.Columns.Add(cLongitude);
            tblRes.Columns.Add(cCityName);
            tblRes.Columns.Add(cCityAbbreviation);
            tblRes.Columns.Add(cCountyName);
            tblRes.Columns.Add(cCountyFIPS);
            tblRes.Columns.Add(cState);
            tblRes.Columns.Add(cFacilityCode);
            tblRes.Columns.Add(cLastLineIndicator);
            tblRes.Columns.Add(cLastLineNumber);
            tblRes.Columns.Add(cPreferredLastLineNumber);

            int totalResults = 0;

            try
            {
                totalResults = Convert.ToInt32(ResZS.TotalRecords);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Total Record Amount" + " " + ex.ToString());
            }

            int recordCounter = 0;
            txtResults.Text = ResZS.Results;

            while (recordCounter < totalResults)
            {
                // Create a new row
                DataRow newRow1;
                newRow1 = tblRes.NewRow();

                // Add the row to the table
                tblRes.Rows.Add(newRow1);

                // Populate the row
                tblRes.Rows[recordCounter]["Record ID"] = ResZS.ZipRecord[recordCounter].RecordID;
                tblRes.Rows[recordCounter]["Zip"] = ResZS.ZipRecord[recordCounter].Zip;
                tblRes.Rows[recordCounter]["Zip Type"] = ResZS.ZipRecord[recordCounter].ZipType;
                tblRes.Rows[recordCounter]["TimeZone Name"] = ResZS.ZipRecord[recordCounter].TimeZone.Name;
                tblRes.Rows[recordCounter]["TimeZone Code"] = ResZS.ZipRecord[recordCounter].TimeZone.Code;
                tblRes.Rows[recordCounter]["Area Code"] = ResZS.ZipRecord[recordCounter].AreaCode;
                tblRes.Rows[recordCounter]["City Name"] = ResZS.ZipRecord[recordCounter].City.Name;
                tblRes.Rows[recordCounter]["City Abbreviation"] = ResZS.ZipRecord[recordCounter].City.Abbreviation;
                tblRes.Rows[recordCounter]["County Name"] = ResZS.ZipRecord[recordCounter].County.Name;
                tblRes.Rows[recordCounter]["County FIPS"] = ResZS.ZipRecord[recordCounter].County.FIPS;
                tblRes.Rows[recordCounter]["State"] = ResZS.ZipRecord[recordCounter].State;
                tblRes.Rows[recordCounter]["Facility Code"] = ResZS.ZipRecord[recordCounter].FacilityCode;
                tblRes.Rows[recordCounter]["LastLine Indicator"] = ResZS.ZipRecord[recordCounter].LastLineIndicator;
                tblRes.Rows[recordCounter]["LastLine Number"] = ResZS.ZipRecord[recordCounter].LastLineNumber;
                tblRes.Rows[recordCounter]["Preferred LastLine Number"] = ResZS.ZipRecord[recordCounter].PreferredLastLineNumber;

                recordCounter++;
            }

        }

      

        
    }
}
