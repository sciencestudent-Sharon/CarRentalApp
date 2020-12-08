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
    public partial class SearchEmployee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public SearchEmployee()
        {
            InitializeComponent();
            // replace server name with your local name
            String connectionString = "Server =JESHERIN\\MSSQLSERVER01; Database = CarRentalDB; Trusted_Connection = yes;";

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

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //insert query
                myCommand.CommandText = "insert into Employee (EID, First_Name, Last_Name, Position, Branch_ID) values (" +
                   EmpID_Tbox.Text.Trim() + ",'" + FName_Tbox.Text.Trim() + "', '" + LastName_Tbox.Text.Trim() + "', '" +
                   Pos_Tbox.Text.Trim() + "', '" + BranchID_Tbox.Text.Trim() + "')";

                MessageBox.Show("Employee added!");

                myCommand.ExecuteNonQuery();

                populateData();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void Province_Label_Click(object sender, EventArgs e)
        {

        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            populateData();
        }

        private void populateData()
        {
            myCommand.CommandText = "select * from Employee";
            try
            {

                myReader = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["EID"].ToString(), myReader["First_Name"].ToString(), myReader["Last_Name"].ToString(),
                        myReader["Position"].ToString(), myReader["Branch_ID"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void FName_Tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            //ask for confirmation
            DialogResult dr = MessageBox.Show("Are you sure you want to delete?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
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
                        myCommand.CommandText = "delete from Employee where EID=" + EmpID_Tbox.Text + ";";
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
                    //insert query
                    myCommand.CommandText = "update Employee set First_Name='" + FName_Tbox.Text.Trim() + 
                        "', Last_Name='" + LastName_Tbox.Text.Trim() + "', Position='" + Pos_Tbox.Text.Trim() + 
                        "', Branch_ID='" + BranchID_Tbox.Text.Trim() + "' where EID=" + EmpID_Tbox.Text.Trim() + ";"; ;


                    MessageBox.Show("Employee Updated!");

                    myCommand.ExecuteNonQuery();

                    populateData();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                EmpID_Tbox.Text = row.Cells["EID"].Value.ToString().Trim();
                FName_Tbox.Text = row.Cells["First_Name"].Value.ToString().Trim();
                LastName_Tbox.Text = row.Cells["Last_Name"].Value.ToString().Trim();
                Pos_Tbox.Text = row.Cells["Position"].Value.ToString().Trim();
                BranchID_Tbox.Text = row.Cells["Branch_ID"].Value.ToString().Trim();

            }
            catch (Exception e2)
            {

            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            //Dictionary: key is the COLUMN name from connected SQL db and value is STRING from named Tbox 
            // NOTE: key needs to be MANUALLY adjusted to SQL column
            Dictionary<string, string> TBoxes = new Dictionary<string, string>();
            TBoxes.Add("EID", EmpID_Tbox.Text);
            TBoxes.Add("First_Name", FName_Tbox.Text);
            TBoxes.Add("Last_Name", LastName_Tbox.Text);
            TBoxes.Add("Position", Pos_Tbox.Text);
            TBoxes.Add("Branch_ID", BranchID_Tbox.Text);


            //init search enquiry
            string search = "select * from Employee where";

            try
            {

                // attach search term if the associated tbox is not empty
                foreach (KeyValuePair<string, string> entry in TBoxes)
                    if ((entry.Key == "Branch_ID" | entry.Key == "EID") && entry.Value != "")
                    {
                        search += " ";
                        search += entry.Key;
                        search += " = ";
                        search += entry.Value;
                        search += " and";
                    }
                    // insert quotation marks for non-int search
                    else if (entry.Key != "Branch_ID" && entry.Key != "EID" && entry.Value != "")
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
                if (search == "select * from Employee where")
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

        private void populateSearchData(string command)
        {
            try
            {

                myReader = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["EID"].ToString(), myReader["First_Name"].ToString(), myReader["Last_Name"].ToString(),
                        myReader["Position"].ToString(), myReader["Branch_ID"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.TextBox> TBoxes = new List<System.Windows.Forms.TextBox>();
            TBoxes.Add(EmpID_Tbox);
            TBoxes.Add(FName_Tbox);
            TBoxes.Add(LastName_Tbox);
            TBoxes.Add(Pos_Tbox);
            TBoxes.Add(BranchID_Tbox);

            foreach (System.Windows.Forms.TextBox tbox in TBoxes)
            {
                tbox.Clear();
            }

            populateData();
        }
    }
        
 }
