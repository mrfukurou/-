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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            double a = Convert.ToDouble(rash.Text);
            double b = Convert.ToDouble(rasst.Text);
            double c = Convert.ToDouble(price.Text);
                if (a > 0 && b > 0 && c > 0)
                {
                    itog.Text = Convert.ToString(a / 100 * b);
                    stoim.Text = Convert.ToString(Convert.ToDouble(itog.Text) * c);
                    label11.Text = "";
                }
                else { throw new Exception(); }
            }
            catch { label11.Text = Convert.ToString("Некорректный ввод!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rash.Clear();
            rasst.Clear();
            price.Clear();
            itog.Clear();
            stoim.Clear();
            label11.Text = "";
        }
       
    }
}
