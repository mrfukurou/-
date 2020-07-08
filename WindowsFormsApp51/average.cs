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
    public partial class average_calculation : Form
    {
        public average_calculation()
        {
            InitializeComponent();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(izrs.Text) > 0 && Convert.ToDouble(rasst.Text) > 0 && Convert.ToDouble(price.Text) > 0)
                {
                    stoim.Text = Convert.ToString(Convert.ToDouble(izrs.Text) * Convert.ToDouble(price.Text));
                    sr.Text = Convert.ToString(Convert.ToDouble(izrs.Text) * 100 / Convert.ToDouble(rasst.Text));
                    attention.Text = "";
                }
                else { throw new Exception(); }
            }
            catch { attention.Text = Convert.ToString("Некорректный ввод!"); }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            izrs.Clear();
            rasst.Clear();
            price.Clear();
            sr.Clear();
            stoim.Clear();
            attention.Text = "";

        }
    }
}
