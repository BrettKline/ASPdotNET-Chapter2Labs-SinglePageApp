using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Random RNG = new Random();
            int compPlay = RNG.Next(1, 4);

            string humanPlay = textBoxInput.Text;
            switch (humanPlay)
            {
                case "r":
                case "R":
                    {
                        switch (compPlay)
                        {
                            case 1:
                                {
                                    labelResult.Text = "You tied with the computer, who played rock.";
                                    break;
                                }
                            case 2:
                                {
                                    labelResult.Text = "You lost to the computer, who played paper.";
                                    break;
                                }
                            case 3:
                                {
                                    labelResult.Text = "You won against the computer, who played scissors.";
                                    break;
                                }
                            default:
                                {
                                    labelResult.Text = "Something unexpected happened.";
                                    break;
                                }
                        }
                        break;
                    }
                case "p":
                case "P":
                    {
                        switch (compPlay)
                        {
                            case 1:
                                {
                                    labelResult.Text = "You won against the computer, who played rock.";
                                    break;
                                }
                            case 2:
                                {
                                    labelResult.Text = "You tied with the computer, who played paper.";
                                    break;
                                }
                            case 3:
                                {
                                    labelResult.Text = "You lost to the computer, who played scissors.";
                                    break;
                                }
                            default:
                                {
                                    labelResult.Text = "Something unexpected happened.";
                                    break;
                                }
                        }
                        break;
                    }
                case "s":
                case "S":
                    {
                        switch (compPlay)
                        {
                            case 1:
                                {
                                    labelResult.Text = "You lost to the computer, who played rock.";
                                    break;
                                }
                            case 2:
                                {
                                    labelResult.Text = "You won against the computer, who played paper.";
                                    break;
                                }
                            case 3:
                                {
                                    labelResult.Text = "You tied with the computer, who played scissors.";
                                    break;
                                }
                            default:
                                {
                                    labelResult.Text = "Something unexpected happened.";
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        labelResult.Text = "Something unexpected happened.";
                        break;
                    }

            }
        }
    }
}
