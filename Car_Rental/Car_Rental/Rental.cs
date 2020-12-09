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
    public partial class Rental : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Rental()
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            this.rentalTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentalReserve reserve = new RentalReserve();
            reserve.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalReturn ret = new RentalReturn();
            ret.Show();
            populateData("select * from Rental_Trans");
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

                rentalTable.Rows.Clear();
                while (myReader.Read())
                {
                    rentalTable.Rows.Add(myReader["Rental_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString(),
                        myReader["price"].ToString(), myReader["Customer_ID"].ToString(), myReader["Employee_ID"].ToString(), myReader["pickup_Branch_ID"].ToString()
                        , myReader["return_Branch_ID"].ToString(), myReader["VIN"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            populateData("select * from Rental_Trans");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchID_Tbox.Text != "")
            {
                myCommand.CommandText = "select * from Rental_Trans where Rental_ID= " + searchID_Tbox.Text.Trim();
                myCommand.ExecuteNonQuery();

                populateData(myCommand.CommandText);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            populateData("select * from Rental_Trans");
        }
    }
}