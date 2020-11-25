using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Branch : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Branch()
        {
            InitializeComponent();

            // replace server name with your local name
            String connectionString = "Server =laptop-7d5uinee; Database = CarRentalDB; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            this.branchTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Branch_Load(object sender, EventArgs e)
        {
            populateData();
        }

        /// <summary>
        /// This function inserts data into the DataGridView
        /// </summary>
        private void populateData()
        {
            myCommand.CommandText = "select * from Branches";
            try
            {

                myReader = myCommand.ExecuteReader();

                branchTable.Rows.Clear();
                while (myReader.Read())
                {
                    branchTable.Rows.Add(myReader["Branch_ID"].ToString(), myReader["street_number"].ToString(), myReader["street_name"].ToString(),
                        myReader["city"].ToString(), myReader["province"].ToString(), myReader["zip"].ToString(), myReader["phone_number"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //insert query
                myCommand.CommandText = "insert into Branches (Branch_ID, street_name, street_number, city, province, zip, phone_number) values (" +
                   BranchID_Tbox.Text.Trim() + ",'" + streetName_Tbox.Text.ToUpper().Trim() + "', '" + streetNum_Tbox.Text.ToUpper().Trim() + "', '" +
                   City_Tbox.Text.ToUpper().Trim() + "', '" + Province_Tbox.Text.ToUpper().Trim() + "', '" + Zip_Tbox.Text.ToUpper().Trim() + "', '" + PhNum_Tbox.Text.Trim() + "')";

                MessageBox.Show("Branch added!");

                myCommand.ExecuteNonQuery();

                populateData();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (BranchID_Tbox.Text == "")
            {
                MessageBox.Show("Please fill missing information!");
            }
            else
            {

                try
                {
                    //delete branch query
                    myCommand.CommandText = "delete from Branches where Branch_ID=" + BranchID_Tbox.Text + ";";
                    MessageBox.Show("Branch deleted!");

                    myCommand.ExecuteNonQuery();

                    populateData();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (BranchID_Tbox.Text == "")
            {
                MessageBox.Show("Please fill missing information!");
            }
            else
            {

                try
                {
                    //update branch query
                    myCommand.CommandText = "update Branches set street_number='" + streetNum_Tbox.Text.Trim() +
                         "', street_name='" + streetName_Tbox.Text.ToUpper().Trim() + "', city='" + City_Tbox.Text.ToUpper().Trim() +
                          "', province='" + Province_Tbox.Text.ToUpper().Trim() + "', zip='" + Zip_Tbox.Text.ToUpper().Trim() + "', phone_number='" + PhNum_Tbox.Text.Trim() +
                          "' where Branch_ID=" + BranchID_Tbox.Text.Trim() + ";";

                    MessageBox.Show("Branch Updated!");

                    myCommand.ExecuteNonQuery();

                    populateData();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }


        //
        // visualize search results
        //
        private void populateSearchData(string command)
        {
            try
            {

                myReader = myCommand.ExecuteReader();

                branchTable.Rows.Clear();
                while (myReader.Read())
                {
                    branchTable.Rows.Add(myReader["Branch_ID"].ToString(), myReader["street_number"].ToString(), myReader["street_name"].ToString(),
                        myReader["city"].ToString(), myReader["province"].ToString(), myReader["zip"].ToString(), myReader["phone_number"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }



        private void Search_Button_Click(object sender, EventArgs e)
        {
            //Dictionary: key is the COLUMN name from connected SQL db and value is STRING from named Tbox 
            // NOTE: key needs to be MANUALLY adjusted to SQL column
            Dictionary<string, string> TBoxes = new Dictionary<string, string>();
            TBoxes.Add("Branch_ID", BranchID_Tbox.Text);
            TBoxes.Add("street_number", streetNum_Tbox.Text);
            TBoxes.Add("street_name", streetName_Tbox.Text);
            TBoxes.Add("city", City_Tbox.Text);
            TBoxes.Add("province", Province_Tbox.Text);
            TBoxes.Add("zip", Zip_Tbox.Text);
            TBoxes.Add("phone_number", PhNum_Tbox.Text);

            //init search enquiry
            string search = "select * from Branches where";

            try
            {

                // attach search term if the associated tbox is not empty
                foreach (KeyValuePair<string, string> entry in TBoxes)
                    if ((entry.Key == "Branch_ID" | entry.Key == "street_number") && entry.Value != "")
                    {
                        search += " ";
                        search += entry.Key;
                        search += " = ";
                        search += entry.Value;
                        search += " and";
                    } 
                    // insert quotation marks for non-int search
                    else if (entry.Key != "Branch_ID" && entry.Key != "street_number" && entry.Value != "")
                    {
                        search += " ";
                        search += entry.Key;
                        search += " = ";
                        search += "'";
                        search += entry.Value;
                        search += "'";
                        search += " and";
                    }

                // remove hanging 'and' from search
                // attach ';' to search before inputting as an SQL command
                if (search.Substring(search.Length - 3) == "and")
                {
                    search = search.Remove(search.Length - 3);
                    search += ";";
                }

                //handle SEARCH button click without search term entries
                if (search == "select * from Branches where")
                {
                    MessageBox.Show("Please fill missing information!");
                }

                //query db
                myCommand.CommandText = search;
                myCommand.ExecuteNonQuery();

                //use populateSearchData() to view search results 
                populateSearchData(myCommand.CommandText);

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// <summary>
        /// sets fields to what is clicked in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void branchTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.branchTable.Rows[e.RowIndex];
                BranchID_Tbox.Text = row.Cells["Branch_ID"].Value.ToString().Trim();
                streetNum_Tbox.Text = row.Cells["street_number"].Value.ToString().Trim();
                streetName_Tbox.Text = row.Cells["street_name"].Value.ToString().Trim();
                City_Tbox.Text = row.Cells["city"].Value.ToString().Trim();
                Province_Tbox.Text = row.Cells["province"].Value.ToString().Trim();
                Zip_Tbox.Text = row.Cells["zip"].Value.ToString().Trim();
                PhNum_Tbox.Text = row.Cells["phone_number"].Value.ToString().Trim();
            }
            catch (Exception e2)
            {

            }
        }

        private void BranchID_Tbox_TextChanged(object sender, EventArgs e)
        {

        }

        //
        // clears contents in tboxes & resets dataview table
        //
        private void ClearSearch_Button_Click(object sender, EventArgs e)
        {

            List<System.Windows.Forms.TextBox> TBoxes = new List<System.Windows.Forms.TextBox>();
            TBoxes.Add(BranchID_Tbox);
            TBoxes.Add(streetNum_Tbox);
            TBoxes.Add(streetName_Tbox);
            TBoxes.Add(City_Tbox);
            TBoxes.Add(Province_Tbox);
            TBoxes.Add(Zip_Tbox);
            TBoxes.Add(PhNum_Tbox);

            foreach (System.Windows.Forms.TextBox tbox in TBoxes)
            {
                tbox.Clear();
            }

            populateData();

        }
    }
}
