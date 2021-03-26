using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_3laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_b.Items.Add("1.1");
            combo_b.Items.Add("1.3");
            combo_b.Items.Add("1.5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double z = 0;
            float x = float.Parse(textBox_x.Text);
            double eva = Math.E;
            double a3 = 0;
            double result = 0;


            switch (combo_b.SelectedIndex)
            {
                case 0: b = 1.1; break;
                case 1: b = 1.3; break;
                case 2: b = 1.5; break;

            }

            if (a1.Checked)
                a = 0.8;
            a3 = Math.Pow(a, 3);
            if (a2.Checked)
                a = 2.2;
            a3 = Math.Pow(a, 3);
            if (a_3.Checked)
                a = 3.2;
            a3 = Math.Pow(a, 3);


            if (z1.Checked == true)
            {
                z = Math.Pow(eva, x);
            }
            if (z2.Checked == true)
            {
                double x2 = Math.Pow(x, 2);
                z = Math.Pow(eva, x2);
            }
            if (z3.Checked == true)
            {
                z = Math.Pow(eva, 3);
            }

            if (x < a3)
            {
                double sin1 = Math.Sin(x);
                double sin_25 = Math.Pow(sin1, 2.5);
                double f = ((z * x) + a);
                double cos1 = Math.Cos(f);
                result = (a * sin_25) + (cos1 * b);
                result_label.Text = result.ToString();


            }

            if (b >= x)
            {
                double sec1 = (a + (b * x));
                double sec2 = Math.Pow(sec1, 2);
                double sin2 = Math.Sin(a + (z * x));
                result = (sec2 - sin2);
                result_label.Text = result.ToString();

            }

            if (x > b)
            {
                double th = ((a + (b * x) + z) - x);
                result = Math.Pow(th, (1 / 2));

                result_label.Text = result.ToString();

            }
        }
    }
}
