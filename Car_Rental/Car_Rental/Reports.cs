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
    public partial class Reports : Form

    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlCommand myCommand1;
        public SqlDataReader myReader;
        public SqlDataReader myReader1;


        public Reports()
        {
            InitializeComponent();
            // replace server name with your local name
            //String connectionString = "Server =JESHERIN\\MSSQLSERVER01; Database = CarRentalDB; Trusted_Connection = yes;";
            String connectionString = "Server =laptop-7d5uinee; Database = CarRentalDB; Trusted_Connection = yes;MultipleActiveResultSets=true;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand1 = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
                myCommand1.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            var strBuild = new System.Text.StringBuilder();

            int test = this.comboBox1.SelectedIndex;
            switch (test)
            {
                case 0:
                    findAvgRentalPeriod(myCommand1, myReader1);
                    break;

                case 1:
                    this.ReeportText.Text = "Option 2";
                    break;
                case 2:
                    this.ReeportText.Text = "Option 3";
                    myCommand.CommandText = "select dbo.Branches.Branch_ID, dbo.Branches.street_name, dbo.Branches.street_number from dbo.Branches, " +
                        "(select dbo.Rental_Trans.pickup_Branch_ID from dbo.Rental_Trans group by pickup_Branch_ID having COUNT(pickup_Branch_ID) = " +
                        "(SELECT MAX(mycount) FROM( SELECT pickup_Branch_ID, COUNT(pickup_Branch_ID) mycount FROM dbo.Rental_Trans GROUP BY pickup_Branch_ID) " +
                        "as mycount) ) as most where dbo.Branches.Branch_ID = most.pickup_Branch_ID; ";

                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        
                        strBuild.Append(myReader[0].ToString() + " ");
                        strBuild.Append(myReader[1].ToString() + " ");
                        strBuild.Append(myReader[2].ToString() + "\n");
                    }

                    this.ReeportText.Text = strBuild.ToString();
                    break;
                default:
                    this.ReeportText.Text = "Please Select a report";
                    break;

            }
            
        }

        private void findAvgRentalPeriod(SqlCommand command, SqlDataReader reader)
        {
            string toDisplay = "";
            var strBuild = new System.Text.StringBuilder();
            int associatedBranchesVal = 0; int days = 0; int overallAvg = 0;

            this.ReeportText.Text = "Option 1:\n\n";
            this.ReeportText.Text += "Average rental period per associated branches (pick up AND drop off).\nRental period is reviewed in days.\n\n";
            myCommand1.CommandText =
                "select CONCAT(pickup_Branch_ID, return_Branch_ID) as \"Branches(PickUp, Dropoff)\", " +
                "avg(rental_period) \"Average Rental Period(Days)\"" +
                "from (select pickup_Branch_ID, return_Branch_ID, DATEDIFF(d, pickup_date, return_date) " +
                "rental_period from Rental_Trans) as RentalPeriod group by pickup_Branch_ID, return_Branch_ID; ";

            this.ReeportText.Text += "Branches (Pickup, Dropoff)     Average Rental Period (Days)\n";
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {

                strBuild.Append(myReader1[0].ToString() + "                              "); // tab doesn't work  ~SL
                strBuild.Append(myReader1[1].ToString() + " \n");
                string daysStr = myReader1[1].ToString(); associatedBranchesVal += 1; days += int.Parse(daysStr);
            }
            myReader1.Close();
            overallAvg = days / associatedBranchesVal;
            this.ReeportText.Text += strBuild.ToString();
            this.ReeportText.Text += "\n\nOverall average rental period was: " + overallAvg + " days.";
            toDisplay = this.ReeportText.Text;
        }


        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
