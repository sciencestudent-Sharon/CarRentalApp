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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.ShowDialog();
        }
    }
}
