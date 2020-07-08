using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void final_calc_Click(object sender, EventArgs e)
        {
            new final_calculation().Show();
        }

        private void average_calc_Click(object sender, EventArgs e)
        {
            new average_calculation().Show();
        }
    }
}
