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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
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
        }
    }
}
