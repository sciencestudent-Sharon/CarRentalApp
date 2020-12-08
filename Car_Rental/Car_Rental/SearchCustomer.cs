using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class SearchCustomer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public SearchCustomer()
        {
            InitializeComponent();

            // replace server name with your local name
            String connectionString = "Server =laptop-7d5uinee; Database = CarRentalDB; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            this.customersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /*
         *  shows customer table info on open
         */
        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            populateData();
        }


        /// <summary>
        /// This function inserts data into the DataGridView
        /// 
        /// method derived from Branch.cs
        /// </summary>
        private void populateData()
        {
            myCommand.CommandText = "select * from Customers";
            try
            {

                myReader = myCommand.ExecuteReader();

                customersTable.Rows.Clear();

                while (myReader.Read())
                {
                    customersTable.Rows.Add(
                        myReader["CustomerID"].ToString(),
                        myReader["first_name"].ToString(),
                        myReader["last_name"].ToString(),
                        myReader["Driving_License"].ToString(),
                        myReader["membership"].ToString(),
                        myReader["street_name"].ToString(),
                        myReader["street_number"].ToString(),
                        myReader["apt_number"].ToString(),
                        myReader["city"].ToString(),
                        myReader["province"].ToString(),
                        myReader["zip"].ToString(),
                        myReader["phone_number"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }


        /*
         *  from Branch.cs
         */
        private void customersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.customersTable.Rows[e.RowIndex];
                CustID_Tbox.Text = row.Cells["CustomerID"].Value.ToString().Trim();
                firstName_Tbox.Text = row.Cells["first_name"].Value.ToString().Trim();
                lastName_Tbox.Text = row.Cells["last_name"].Value.ToString().Trim();
                City_Tbox.Text = row.Cells["city"].Value.ToString().Trim();
                Province_Tbox.Text = row.Cells["province"].Value.ToString().Trim();
                PhNum_Tbox.Text = row.Cells["phone_number"].Value.ToString().Trim();
            }
            catch (Exception e4)
            {

            }
        }

        /*
         * visualizes search results into dataview
         * ~SL
         */
        private void populateSearchData(string command)
        {
            try
            {

                myReader = myCommand.ExecuteReader();

                customersTable.Rows.Clear();
                while (myReader.Read())
                {
                    customersTable.Rows.Add(
                        myReader["CustomerID"].ToString(),
                        myReader["first_name"].ToString(),
                        myReader["last_name"].ToString(),
                        myReader["Driving_License"].ToString(),
                        myReader["membership"].ToString(),
                        myReader["street_name"].ToString(),
                        myReader["street_number"].ToString(),
                        myReader["apt_number"].ToString(),
                        myReader["city"].ToString(),
                        myReader["province"].ToString(),
                        myReader["zip"].ToString(),
                        myReader["phone_number"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        /*
         * Method empties Tboxes/fields in form SearchCustomer.cs
         * ~SL
         */
        private void clearTboxes()
        {
            List<System.Windows.Forms.TextBox> TBoxes = new List<System.Windows.Forms.TextBox>();
            TBoxes.Add(CustID_Tbox);
            TBoxes.Add(firstName_Tbox);
            TBoxes.Add(lastName_Tbox);
            TBoxes.Add(City_Tbox);
            TBoxes.Add(Province_Tbox);
            TBoxes.Add(PhNum_Tbox);

            foreach (System.Windows.Forms.TextBox tbox in TBoxes)
            {
                tbox.Clear();
            }
        }


        /********************** DEAL WITH BUTTONS ***************************/


        private void AddUpdate_Button_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.ShowDialog();

            // if info was added/updated, clear & re-populate   ~SL
            customersTable.Rows.Clear();
            populateData();

        }


        /*
         * handles delete button - removes existing item from db
         * method modified from Branch.cs
         *
         */
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            // check for empty customer ID  ~SL
            if (CustID_Tbox.Text == "")
            {
                MessageBox.Show("Please fill in Customer ID.");
            }
            else
            {
                //ask for confirmation
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?",
                    "Confirmation", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {

                    try
                    {
                        //delete branch query
                        myCommand.CommandText = "delete from Customers where CustomerID=" + CustID_Tbox.Text + ";";
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Customer ID:" + CustID_Tbox.Text + ", information deleted.");
                        clearTboxes();
                        populateData();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.ToString(), "Error");
                    }

                }


            }
        }


        private void Search_Button_Click(object sender, EventArgs e)
        {
            //Dictionary: key is the COLUMN name from connected SQL db and value is STRING from named Tbox ~SL
            // NOTE: key needs to be MANUALLY adjusted to SQL column ~SL
            Dictionary<string, string> TBoxes = new Dictionary<string, string>();
            TBoxes.Add("CustomerID", CustID_Tbox.Text);
            TBoxes.Add("first_name", firstName_Tbox.Text);
            TBoxes.Add("last_name", lastName_Tbox.Text);
            TBoxes.Add("city", City_Tbox.Text);
            TBoxes.Add("province", Province_Tbox.Text);
            TBoxes.Add("phone_number", PhNum_Tbox.Text);

            try
            {
                //init search enquiry ~SL
                string search = "select * from Customers where";

                // attach search term if the associated tbox is not empty ~SL
                foreach (KeyValuePair<string, string> entry in TBoxes)
                    if (entry.Value != "")
                    {

                        if (entry.Key == "CustomerID" || entry.Key == "phone_number")
                        {
                            search += " " + entry.Key + " = ";
                            search += entry.Value;
                            search += " and";
                        }
                        else
                        {
                            search += " " + entry.Key + " = ";
                            search += "'" + entry.Value + "'";
                            search += " and";
                        }
                    }

                // remove hanging 'and' from search ~SL
                // attach ';' to search before inputting as an SQL command ~SL
                if (search.Substring(search.Length - 3) == "and")
                {
                    search = search.Remove(search.Length - 4);
                    search += ";";
                }

                //handle SEARCH button click without search term entries ~SL
                if (search == "select * from Customers where")
                {
                    MessageBox.Show("Please fill missing information!");
                }
                else
                {
                    //query db ~SL
                    myCommand.CommandText = search;
                    myCommand.ExecuteNonQuery();

                    //use populateSearchData() to view search results ~SL
                    populateSearchData(myCommand.CommandText);
                }



            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /*
         * Method clears Tboxes and then repopulates table with all info.
         * ~SL
         */
        private void ClearSearch_Button_Click(object sender, EventArgs e)
        {
            clearTboxes();
            populateData();
        }
    }
}