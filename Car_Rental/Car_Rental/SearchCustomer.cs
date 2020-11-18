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
    public partial class SearchCustomer : Form
    {

        public SearchCustomer()
        {
            InitializeComponent();
        }


        public void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.ShowDialog();
        }

        private void labelCarVIN_Click(object sender, EventArgs e)
        {

        }

    }
}
