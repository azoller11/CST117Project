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
            lb_planets.Items.Add("Earth");
            lb_planets.SetSelected(0, true);
            

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
                //Checks is the user has selected a celestial body
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
            } else if (lb_planets.SelectedIndex == 6)
            {
                ew *= 1.0; //Earth Conversion lol why??
                
            }
            else
            {
                MessageBox.Show("Please select a celestial body.");
            }




            //Formats then sets the text to the calculated numer (3 decimal places)
            tb_finalWeight.Text = String.Format("{0:0.000}", ew);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pb_planet_Click(object sender, EventArgs e)
        {

        }
    }
}
