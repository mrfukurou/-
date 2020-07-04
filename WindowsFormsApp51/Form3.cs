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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                double a = Convert.ToDouble(izrs.Text);
                double b = Convert.ToDouble(rasst.Text);
                double c = Convert.ToDouble(price.Text);
                if (a > 0 && b > 0 && c > 0)
                {
                    stoim.Text = Convert.ToString(Convert.ToDouble(izrs.Text) * c);
                    sr.Text = Convert.ToString(Convert.ToDouble(izrs.Text) * 100 / b);
                    label11.Text = "";
                }
                else { throw new Exception(); }
            }
            catch { label11.Text = Convert.ToString("Некорректный ввод!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            izrs.Clear();
            rasst.Clear();
            price.Clear();
            sr.Clear();
            stoim.Clear();
            label11.Text = "";

        }
    }
}
