using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Sin(double x)
        {
            return (Math.Sin(x * Math.PI / 100.0));
        }

        double Asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double Cos(double x)
        {
            return (Math.Cos(x * Math.PI / 100.0));
        }

        double Acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double force, angle;
            try
            {
                force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + " ,Put numbers in you git");
                force = 0.0;
            }

            try
            {
                angle = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show(textBox2.Text + " ,Put numbers in you git");
                angle = 0.0;
            }
            

            double Fx = force * Cos(angle);
            label3.Text = "Fx =" + Fx;

            double Fy = force * Sin(angle);
            label4.Text = "Fy =" + Fy;

        }
    }
}
