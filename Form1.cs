using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_planets.Items.Add("Mars");
            lb_planets.Items.Add("Venus");
            lb_planets.Items.Add("Mercury");
            lb_planets.Items.Add("Saturn");
            lb_planets.Items.Add("Jupiter");
            lb_planets.Items.Add("Moon");

        }

        private void lb_planets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_finalWeight_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            //Get weight inputed
            double ew = 0;

            try
            {
                ew = Double.Parse(tb_enterWeight.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Please enter your weight in pounds (lbs)");
            }
          
             
            if (lb_planets.SelectedIndex == 0)
            {
                ew *= 0.377; //Mars Conversion
            } else if (lb_planets.SelectedIndex == 1)
            {
                ew *= 0.887; //Venus Conversion
            } else if (lb_planets.SelectedIndex == 2)
            {
                ew *= 0.37; //Mercury Conversion
            } else if (lb_planets.SelectedIndex == 3)
            {
                ew *= 1.044; //Saturn Conversion
            } else if (lb_planets.SelectedIndex == 4)
            {
                ew *= 2.479; //Jupiter Conversion
            } else if (lb_planets.SelectedIndex == 5)
            {
                ew *=  0.1622; //Moon Conversion
            } else
            {
                MessageBox.Show("Please select a celestial body.");
            }





            tb_finalWeight.Text = String.Format("{0:0.000}", ew);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
