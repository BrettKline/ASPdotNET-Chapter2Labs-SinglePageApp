using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            int birthMonth = Convert.ToInt32(textBoxBMonth.Text);
            int birthDay = Convert.ToInt32(textBoxBDay.Text);
            if (birthMonth < 1 || birthMonth > 12)
            {
                labelResult.Text = "Invalid month";
            }
            else
            {
                switch (birthMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            if (birthDay > 31 || birthDay < 1)
                            {
                                labelResult.Text = "Invalid day";
                            }
                            else
                            {
                                labelResult.Text = String.Format("Your birthday is on {0}/{1}.", birthMonth, birthDay);
                            }
                            break;
                        }
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        {
                            if (birthDay > 30 || birthDay < 1)
                            {
                                labelResult.Text = "Invalid day";
                            }
                            else
                            {
                                labelResult.Text = String.Format("Your birthday is on {0}/{1}.", birthMonth, birthDay);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (birthDay > 29 || birthDay < 1)
                            {
                                labelResult.Text = "Invalid day";
                            }
                            else
                            {
                                labelResult.Text = String.Format("Your birthday is on {0}/{1}.", birthMonth, birthDay);
                            }
                            break;
                        }
                    default:
                        {
                            labelResult.Text = "Invalid entry";
                            break;
                        }
                }
            }
        }
    }
}
