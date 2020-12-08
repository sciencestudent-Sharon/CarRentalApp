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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

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
                    break;
                default:
                    this.ReeportText.Text = "Please Select a report";
                    break;

            }
            
        }
    }
}
