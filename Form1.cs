using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Numbers_Assignment
{
    public partial class RandomNumbers : Form
    {
        double min, max, output;
        int simpleoutput ;
        Random generator = new Random();

        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(txtMin.Text);
            double  max = Convert.ToDouble(txtMax.Text);
            lblOutput.Text = Convert.ToString(generator.NextDouble() *max);
            lblOutput.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            lblOutput.Visible = true;
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);
            lblOutput.Text = Convert.ToString(generator.Next(min, max + 1));
            lblOutput.BackColor = System.Drawing.Color.Lime;
            lblOutput.Visible = true;
        }
    }
}
