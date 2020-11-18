using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class MainMenu : Form
    {
        //fields
        private Form activeForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function opens child forms in the MainMenu panelDesktop
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="btnSender"></param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
        
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

  
        }

        // button event handlers ---------------------------------------

        private void btnBranches_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Branch(), sender);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cars(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchCustomer(), sender);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchEmployee(), sender);
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
 
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (activeForm != null) 
            {
                activeForm.Close();
                labelTitle.Text = "Home";
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer(), sender);

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
