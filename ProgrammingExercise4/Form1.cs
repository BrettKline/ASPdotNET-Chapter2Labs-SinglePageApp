using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double windSpeed = Convert.ToDouble(textBoxWindSpeed.Text);
            int category;
            if (windSpeed >= 157)
            {
                category = 5;
            }
            else if (windSpeed >= 130)
            {
                category = 4;
            }
            else if (windSpeed >= 111)
            {
                category = 3;
            }
            else if (windSpeed >= 96)
            {
                category = 2;
            }
            else if (windSpeed >= 74)
            {
                category = 1;
            }
            else
            {
                category = 0;
            }
            if (category > 0)
            {
                labelCategory.Text = String.Format("This is a category {0} hurricane.", category);
            }
            else
            {
                labelCategory.Text = "This is not a hurricane.";
            }
        }
    }
}
