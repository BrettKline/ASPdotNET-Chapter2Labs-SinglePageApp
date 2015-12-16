using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int monthInput = Convert.ToInt32(textBoxMonth.Text);
            if ((monthInput > 12) || monthInput < 1)
            {
                labelResult.Text = "Not a valid month";
            } 
            else
            {
                labelResult.Text = "A valid month";
            }
        }
    }
}
