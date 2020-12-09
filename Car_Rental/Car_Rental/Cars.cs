using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Cars : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Cars()
        {
            InitializeComponent();

            // replace server name with your local name
            //String connectionString = "Server =DESKTOP-B46CGSV; Database = CarRentalDB; Trusted_Connection = yes;";
            String connectionString = "Server =laptop-7d5uinee; Database = CarRentalDB; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection

                //insert CarTypes into choice box
                myCommand.CommandText = "select distinct CarType from Car_types";
                SqlDataReader DR = myCommand.ExecuteReader();

                cBoxType.Items.Clear();
                while (DR.Read())
                {
                    cBoxType.Items.Add(DR[0]);
                }
                DR.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            this.carsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Executes given query and updates grid view table
        /// </summary>
        /// <param name="query"></param>
        private void populateData(string query)
        {
            myCommand.CommandText = query;
            try
            {

                myReader = myCommand.ExecuteReader();

                carsTable.Rows.Clear();
                while (myReader.Read())
                {
                    carsTable.Rows.Add(myReader["VIN"].ToString(), myReader["Color"].ToString(), myReader["Model"].ToString(),
                        myReader["CarType"].ToString(), myReader["Branch_ID"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tBoxVIN.Text == "")
            {
                MessageBox.Show("Please fill missing information!");
            }
            else
            {
                try
                {
                    //insert query
                    myCommand.CommandText = "insert into Cars (VIN, Color, Model, CarType, Branch_ID) values (" +
                       tBoxVIN.Text.Trim() + ",'" + tBoxColor.Text.ToUpper().Trim() + "', '" + tBoxModel.Text.ToUpper().Trim() + "', '" +
                       cBoxType.Text.Trim() + "', '" + tBoxBranchID.Text.Trim() + "')";

                    MessageBox.Show("Car added!");

                    myCommand.ExecuteNonQuery();

                    populateData("select * from Cars");

                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tBoxVIN.Text == "")
            {
                MessageBox.Show("Please fill missing information!");
            }
            else
            {

                try
                {
                    //update branch query
                    myCommand.CommandText = "update Cars set Color='" + tBoxColor.Text.ToUpper().Trim() +
                         "', Model='" + tBoxModel.Text.ToUpper().Trim() + "', CarType='" + cBoxType.Text.ToUpper().Trim() +
                          "', Branch_ID=" + tBoxBranchID.Text.Trim() + " where VIN=" + tBoxVIN.Text.Trim() + ";";

                    MessageBox.Show("Car Updated!");

                    myCommand.ExecuteNonQuery();

                    populateData("select * from Cars");
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tBoxVIN.Text == "")
            {
                MessageBox.Show("Please fill missing information!");
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
                        myCommand.CommandText = "delete from Cars where VIN=" + tBoxVIN.Text + ";";
                        MessageBox.Show("Car deleted!");

                        myCommand.ExecuteNonQuery();

                        populateData("select * from Cars");
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.ToString(), "Error");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = createSearchQuery();

            try
            {

                //handle SEARCH button click without search term entries
                if (search == "select * from Cars where")
                {
                    MessageBox.Show("Please fill missing information!");
                }

                //query db
                myCommand.CommandText = search;
                myCommand.ExecuteNonQuery();

                populateData(search);

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.TextBox> TBoxes = new List<System.Windows.Forms.TextBox>();
            TBoxes.Add(tBoxVIN);
            TBoxes.Add(tBoxColor);
            TBoxes.Add(tBoxModel);
            TBoxes.Add(tBoxBranchID);

            foreach (System.Windows.Forms.TextBox tbox in TBoxes)
            {
                tbox.Clear();
            }

            cBoxType.SelectedIndex = -1;

            populateData("select * from Cars");
        }

        private string createSearchQuery()
        {
            //Dictionary: key is the COLUMN name from connected SQL db and value is STRING from named Tbox 
            // NOTE: key needs to be MANUALLY adjusted to SQL column
            Dictionary<string, string> Boxes = new Dictionary<string, string>();
            Boxes.Add("VIN", tBoxVIN.Text.ToUpper().Trim());
            Boxes.Add("Color", tBoxColor.Text.ToUpper().Trim());
            Boxes.Add("Model", tBoxModel.Text.ToUpper().Trim());
            Boxes.Add("CarType", cBoxType.Text);
            Boxes.Add("Branch_ID", tBoxBranchID.Text.ToUpper().Trim());


            //init search enquiry
            string search = "select * from Cars where";

            // attach search term if the associated box is not empty
            foreach (KeyValuePair<string, string> entry in Boxes)
                if ((entry.Key == "VIN" | entry.Key == "Branch_ID") && entry.Value != "")
                {
                    search += " ";
                    search += entry.Key;
                    search += " = ";
                    search += entry.Value;
                    search += " and";
                }
                else if (entry.Key == "Model")
                {
                    search += " ";
                    search += entry.Key;
                    search += " like ";
                    search += "'%";
                    search += entry.Value;
                    search += "%'";
                    search += " and";
                }
                // insert quotation marks for non-int search
                else if (entry.Key != "VIN" && entry.Key != "Branch_ID" && entry.Value != "")
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

            return search;
        }

        /// <summary>
        /// Upon a row click on the DGV, this method inserts the information into the text fields/combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.carsTable.Rows[e.RowIndex];
                tBoxVIN.Text = row.Cells["VIN"].Value.ToString().Trim();
                tBoxColor.Text = row.Cells["Color"].Value.ToString().Trim();
                tBoxModel.Text = row.Cells["Model"].Value.ToString().Trim();
                cBoxType.SelectedIndex = cBoxType.FindString(row.Cells["CarType"].Value.ToString().Trim());
                tBoxBranchID.Text = row.Cells["Branch_ID"].Value.ToString().Trim();

            }
            catch (Exception)
            {

            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            populateData("select * from Cars");
        }

    }
}
