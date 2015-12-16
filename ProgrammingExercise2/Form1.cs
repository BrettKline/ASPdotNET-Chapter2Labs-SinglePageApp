using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (richTextBoxFormat.Text.Length > 140)
            {
                labelResult.Text = String.Format("This message is too long for Twitter.\r\n{0}/140 characters", richTextBoxFormat.Text.Length);
            }
            else
            {
                labelResult.Text = String.Format("This message will fit on twitter.\r\n{0}/140 characters", richTextBoxFormat.Text.Length);
            }
        }
    }
}
