using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ssa = Convert.ToDouble(textBox1.Text);

            double a = 4 * Math.PI * ssa * ssa;

            label10.Text = "" + a;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sv = Convert.ToDouble(textBox1.Text);

            double a = (4.0 / 3.0) * Math.PI * sv * sv * sv;

            label15.Text = "" + a;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
