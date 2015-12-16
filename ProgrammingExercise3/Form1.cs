using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(textBoxGPA.Text);
            double admissionsTest = Convert.ToDouble(textBoxTest.Text);
            if ((gpa >= 3 && admissionsTest >= 60) || (gpa < 3 && admissionsTest >= 80))
            {
                labelResult.Text = "Accepted";
            }
            else
            {
                labelResult.Text = "Rejected";
            }
             
        }
    }
}
