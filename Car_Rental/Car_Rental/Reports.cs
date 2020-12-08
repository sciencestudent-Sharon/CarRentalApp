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
        public SqlDataReader myReader;

        public Reports()
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
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            var strBuild = new System.Text.StringBuilder();

            int test = this.comboBox1.SelectedIndex;
            switch (test)
            {
                case 0:
                    this.ReeportText.Text = "Option 1";
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

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
