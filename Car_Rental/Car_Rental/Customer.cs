using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Customer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Dictionary<string, string> Tboxes = new Dictionary<string, string>();

        public Customer()
        {
            InitializeComponent();

            // replace server name with yours
            String connectionString = "Server =laptop-7d5uinee; Database = CarRentalDB; Trusted_Connection = yes;";

            // new connection for SQL insert only   ~SL
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "error");
                this.Close();
            }

        }


        /*
         * collect user inputs into dict for inserting into SQL table
         * ~SL
         */
        private Dictionary<string, string> populateTboxes()
        {
            Tboxes.Add("CustomerID", CustID_Tbox.Text);
            Tboxes.Add("first_name", FirstName_Tbox.Text);
            Tboxes.Add("last_name", LastName_Tbox.Text);
            Tboxes.Add("Driving_License", License_Tbox.Text);
            Tboxes.Add("membership", Membership_Tbox.Text);
            Tboxes.Add("street_name", StName_Tbox.Text);
            Tboxes.Add("street_number", StNum_Tbox.Text);
            Tboxes.Add("apt_number", AptNum_Tbox.Text);
            Tboxes.Add("city", City_Tbox.Text);
            Tboxes.Add("province", Province_Tbox.Text);
            Tboxes.Add("zip", Zip_Tbox.Text);
            Tboxes.Add("phone_number", PhNum_Tbox.Text);

            return Tboxes;
        }



        /*
         * Checks mandatory fields' tboxes for empty content
         * Returns false if at least one is empty
         * ~SL
         */
        private bool checkFillMandatoryFields()
        {
            // assume all necessary fields have been filled   ~SL
            bool mandatoryFieldsMet = true;

            List<System.Windows.Forms.TextBox> MandatoryFields = new List<System.Windows.Forms.TextBox>();
            MandatoryFields.Add(CustID_Tbox);
            MandatoryFields.Add(FirstName_Tbox);
            MandatoryFields.Add(LastName_Tbox);
            MandatoryFields.Add(License_Tbox);
            MandatoryFields.Add(PhNum_Tbox);

            foreach (System.Windows.Forms.TextBox tbox in MandatoryFields)
            {
                if (tbox.Text == "")
                {
                    mandatoryFieldsMet = false;
                }
            }
            return mandatoryFieldsMet;
        }

        /*
         * Method checks to see if there is an existing cust ID
         * RETURNS TRUE IF ID EXISTS
         * ~SL
         */
        private bool checkCustID()
        {
            //if (CustID_Tbox.Text == "")
            //{
            //    return false;
            //} else
            //{
            string search = "select * from Customers where CustomerID= " + CustID_Tbox.Text;
            myCommand.CommandText = search;
            int resultsNum = myCommand.ExecuteNonQuery();

            if (resultsNum != 0)
            {
                return true;
            }

            return false;


        }

        /*
         * Method clears all Tboxes/fields
         * ~SL
         */
        private void clearTboxes()
        {
            List<System.Windows.Forms.TextBox> TBoxes = new List<System.Windows.Forms.TextBox>();
            TBoxes.Add(CustID_Tbox);
            TBoxes.Add(FirstName_Tbox);
            TBoxes.Add(LastName_Tbox);
            TBoxes.Add(License_Tbox);
            TBoxes.Add(PhNum_Tbox);
            TBoxes.Add(StName_Tbox);
            TBoxes.Add(StNum_Tbox);
            TBoxes.Add(AptNum_Tbox);
            TBoxes.Add(Zip_Tbox);
            TBoxes.Add(City_Tbox);
            TBoxes.Add(Province_Tbox);

            foreach (System.Windows.Forms.TextBox tbox in TBoxes)
            {
                tbox.Clear();
            }

        }


        /************************** DEAL WITH BUTTONS ***********************/


        /*
         * checks & handles mandatory fields for empties (calls method checkMandatoryFields())
         * creates & inserts SQL query
         * ~SL
         */
        private void Save_Button_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (checkFillMandatoryFields() == false)
                {
                    MessageBox.Show("Please review & fill mandatory field(s).");
                    IndicatesMandField_Label.ForeColor = Color.Red; // change label colour for user     ~SL
                    Required_Label.ForeColor = Color.Red;
                    clearTboxes();

                }
                else if (CustID_Tbox.Text != "" && checkCustID() == false)
                {
                    MessageBox.Show(CustID_Tbox.Text + " exists as Customer ID.\nPlease enter a different value.");
                    Required_Label.ForeColor = Color.Red;
                    clearTboxes();
                }
                else
                {

                    myCommand.CommandText = "insert into Customers " +
                        "(CustomerID, first_name, last_name, Driving_License, " +
                        "membership, street_name, street_number, apt_number, city, " +
                        "province, zip, phone_number) values ('" +
                            CustID_Tbox.Text.Trim() + "', '" +
                            FirstName_Tbox.Text.Trim() + "', '" +
                            LastName_Tbox.Text.Trim() + "', '" +
                            License_Tbox.Text.Trim() + "', '" +
                            Membership_Tbox.Text.Trim() + "', '" +
                            StName_Tbox.Text.Trim() + "', '" +
                            StNum_Tbox.Text.Trim() + "', '" +
                            AptNum_Tbox.Text.Trim() + "', '" +
                            City_Tbox.Text.Trim() + "', '" +
                            Province_Tbox.Text.Trim() + "', '" +
                            Zip_Tbox.Text.Trim() + "', '" +
                            PhNum_Tbox.Text.Trim() + "')";

                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("New customer information added.");
                    IndicatesMandField_Label.ForeColor = Color.Black; // change label colour to black   ~SL
                    Required_Label.ForeColor = Color.Black;
                    this.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "error");
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // init update string to later add to   ~SL
                string update = "update Customers set ";

                // track changed fields    ~SL
                string changes = "Changes to:\n";

                // check only if CustomerID is empty    ~SL
                if (CustID_Tbox.Text == "" || checkCustID() == false)
                {
                    MessageBox.Show("Please review Customer ID.\nEmpty or non-existent customer ID.");
                    Required_Label.ForeColor = Color.Red;
                    clearTboxes();
                }
                else
                {

                    // isolate new/updated info for SQL insert   ~SL
                    populateTboxes();

                    foreach (KeyValuePair<string, string> entry in Tboxes)
                        if (entry.Value != "" && entry.Key != "CustomerID")
                        {
                            update += entry.Key + " = '" + entry.Value + "', ";
                            changes += entry.Key + "\n";
                        }

                    // remove hanging characters  ~SL
                    if (update.Substring(update.Length - 2) == ", ")
                    {
                        update = update.Remove(update.Length - 2);
                    }

                    // finalize command string & complete SQL command   ~SL
                    update += " where CustomerID = " + CustID_Tbox.Text.Trim() + "; ";
                    myCommand.CommandText = update;
                    myCommand.ExecuteNonQuery();

                    MessageBox.Show("Customer information updated.\n\n" + changes);
                    IndicatesMandField_Label.ForeColor = Color.Black; // change label colour to black   ~SL
                    Required_Label.ForeColor = Color.Black;
                    this.Close();
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "error");
            }
        }

        //Removed empty referenced controls, also deleted from Customer.Designer.cs     ~SL

    }
}