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
    public partial class RentalReserve : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public RentalReserve()
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

                carType_cBox.Items.Clear();
                while (DR.Read())
                {
                    carType_cBox.Items.Add(DR[0]);
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

        private void btnReserve_Click(object sender, EventArgs e)
        {
            bool error = errorCheck();
            if (!error)
            {
                myCommand.CommandText = createTransaction();
                myCommand.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show("Reserve Successful!");
            }
        }

        private bool errorCheck()
        {
            if (TID_Tbox.Text.Trim() == "" || employeeID_Tbox.Text.Trim() == "" || customerID_Tbox.Text.Trim() == "" 
                || pickupID_Tbox.Text.Trim() == "" || returnID_Tbox.Text.Trim() == "" || VIN_Tbox.Text.Trim() == "" )
            {
                MessageBox.Show("Please fill out all the information!");
                return true;
            }
            return false;
        }

        private string createTransaction()
        {

            

            string query = "insert into Rental_Trans values (";
            

            query += TID_Tbox.Text.Trim() + ", ";
            query += "CAST(N'" + dateTimePicker1.Value.ToShortDateString() + "' AS Date), ";
            query += "CAST(N'" + dateTimePicker2.Value.ToShortDateString() + "' AS Date), ";
            //get price of car
            query += Convert.ToDouble(getPrice())+ ", ";
            query += customerID_Tbox.Text.Trim() + ", ";
            query += employeeID_Tbox.Text.Trim() + ", ";
            query += pickupID_Tbox.Text.Trim() + ", ";
            query += returnID_Tbox.Text.Trim() + ", ";
            query += VIN_Tbox.Text.Trim() +")";

            query += ";";

            return query;
        }

        private string getPrice()
        {
       
            myCommand.CommandText = "select " + getPeriod() + " from Car_types, Cars where Car_types.CarType = Cars.CarType and VIN=" + VIN_Tbox.Text.Trim() + ";";
            myCommand.ExecuteNonQuery();

            string price;
            SqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                if (myReader[0].ToString() != "")
                {
                    price = myReader[0].ToString();
                    myReader.Close();
                    return price;

                }
            }
            myReader.Close();
            return null;
        }

        private string getPeriod()
        {
            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            string daysDiff = diff.Days.ToString();
            int num = Int32.Parse(daysDiff);
            if (num >=29)
            {
                return "price_M";
            }
            else if (num >= 7)
            {
                return "price_W";
            }
            return "price_D";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (customerID_Tbox.Text == "")
            {
                name_Text.Visible = false;
            }
            else
            {
                myCommand.CommandText = "select last_name, first_name  from Customers where CustomerID= " + customerID_Tbox.Text.Trim();
                myCommand.ExecuteNonQuery();

                var strBuild = new System.Text.StringBuilder();

                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    if (myReader[0].ToString() != "")
                    { 
                    strBuild.Append(myReader[0].ToString().Trim() + ", ");
                    strBuild.Append(myReader[1].ToString() + " ");
                    name_Text.Text = strBuild.ToString();
                    name_Text.Visible = true;
                    }
                }
                myReader.Close();
            }
        }

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

        private void RentalReserve_Load(object sender, EventArgs e)
        {
            populateData("select * from Cars where Available = 'YES'");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            populateData(createSearchQuery());
        }

        private string createSearchQuery()
        {
            string query = "select * from Cars where";

            if (pickupID_Tbox.Text != "")
            {
                query += " Branch_ID=" + pickupID_Tbox.Text;
            }
            Dictionary<string, string> Boxes = new Dictionary<string, string>();
            Boxes.Add("Branch_ID", pickupID_Tbox.Text.ToUpper().Trim());
            Boxes.Add("CarType", carType_cBox.Text);

            string search = "select * from Cars where";

            foreach (KeyValuePair<string, string> entry in Boxes)
                if ((entry.Key == "Branch_ID") && entry.Value != "")
                {
                    search += " ";
                    search += entry.Key;
                    search += " = ";
                    search += entry.Value;
                    search += " and";
                }

                else if (entry.Key != "Branch_ID" && entry.Value != "")
                {
                    search += " ";
                    search += entry.Key;
                    search += " = ";
                    search += "'";
                    search += entry.Value;
                    search += "'";
                    search += " and";
                }

            search += " Available = 'YES';";

            return search;
        }

        private void carsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.carsTable.Rows[e.RowIndex];
                VIN_Tbox.Text = row.Cells["VIN"].Value.ToString().Trim();

            }
            catch (Exception)
            {
            }
        }
    }
}