using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    //Student Id: C0804317
    //Student Name: Varij Rughani

    //Jokes: (For reference: https://www.fatherly.com/play/best-coronavirus-jokes/)
    //(1.)If coronavirus isn’t about beer, why do I keep seeing cases of it?
    //(2.)What’s the difference between the Alpha and Delta variant? I don’t know; 
    //    it’s all Greek to me.
    //(3.)I would make a COVID-19 joke, but it would be tasteless

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // For Enter and Escape Key Event Handlers

            if (keyData == (Keys.Enter))
            {
                btn_calc.PerformClick(); //For Enter Key
                return true;
            }
            if (keyData == (Keys.Escape))
            {
                btn_exit.PerformClick(); // For Escape Key
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //For Calculate Button

            //Declaring PI constant
            const double PI = 3.14;

            //Taking Input from the User
            double diameter = Convert.ToDouble(txt_dmeter.Text);

            //Calculating Radius, Area and Perimeter
            double radius = diameter / 2;
            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;

            //Printing Area and Perimeter using Math Function 
            txt_area.Text = Math.Round(area, 3).ToString();
            txt_pmeter.Text = Math.Round(perimeter, 3).ToString();

            //Changing Focus to Diameter
            txt_dmeter.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {   
            // For Exit Button
            this.Close();
        }
    }
}
