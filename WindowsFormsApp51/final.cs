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
    public partial class final_calculation : Form
    {
        public final_calculation()
        {
            InitializeComponent();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(rash.Text) > 0 && Convert.ToDouble(rasst.Text) > 0 && Convert.ToDouble(price.Text) > 0)
                {
                    itog.Text = Convert.ToString(Convert.ToDouble(rash.Text) / 100 * Convert.ToDouble(rasst.Text));
                    stoim.Text = Convert.ToString(Convert.ToDouble(itog.Text) * Convert.ToDouble(price.Text));
                    attention.Text = "";
                }
                else { throw new Exception(); }
            }
            catch { attention.Text = Convert.ToString("Некорректный ввод!"); }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            rash.Clear();
            rasst.Clear();
            price.Clear();
            itog.Clear();
            stoim.Clear();
            attention.Text = "";
        }
       
    }
}
