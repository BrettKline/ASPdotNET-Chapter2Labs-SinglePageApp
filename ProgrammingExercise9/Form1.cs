using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            Random RNG = new Random();
            int lot1, lot2, lot3, guess1, guess2, guess3;
            lot1 = RNG.Next(1, 5);
            lot2 = RNG.Next(1, 5);
            lot3 = RNG.Next(1, 5); 

            int wonReels = 0;

            labelLotRes1.Text = Convert.ToString(lot1);
            labelLotRes2.Text = Convert.ToString(lot2);
            labelLotRes3.Text = Convert.ToString(lot3);

            guess1 = Convert.ToInt32(textBox1.Text);
            guess2 = Convert.ToInt32(textBox2.Text);
            guess3 = Convert.ToInt32(textBox3.Text);

            const string PW = "PERFECT WIN!! $10000!!";
            const string TW = "TRIPLE WIN! $1000!";
            const string DW = "Double win! $100!";
            const string SW = "Single win. $10.";
            const string LOSS = "Loss.";

            bool perfectWin = false;

            if ((lot1 == guess1 && lot2 == guess2 && lot3 == guess3))
            {
                perfectWin = true;
            }

            switch (guess1)
            {
                case 1:
                    {
                        if ((lot1 == 1) || (lot2 == 1) || (lot3 == 1))
                        {
                            wonReels++;
                            if (lot1 == 1)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 1)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 1)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if ((lot1 == 2) || (lot2 == 2) || (lot3 == 2))
                        {
                            wonReels++;
                            if (lot1 == 2)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 2)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 2)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if ((lot1 == 3) || (lot2 == 3) || (lot3 == 3))
                        {
                            wonReels++;
                            if (lot1 == 3)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 3)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 3)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if ((lot1 == 4) || (lot2 == 4) || (lot3 == 4))
                        {
                            wonReels++;
                            if (lot1 == 4)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 4)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 4)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
            }

            switch (guess2)
            {
                case 1:
                    {
                        if ((lot1 == 1) || (lot2 == 1) || (lot3 == 1))
                        {
                            wonReels++;
                            if (lot1 == 1)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 1)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 1)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if ((lot1 == 2) || (lot2 == 2) || (lot3 == 2))
                        {
                            wonReels++;
                            if (lot1 == 2)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 2)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 2)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if ((lot1 == 3) || (lot2 == 3) || (lot3 == 3))
                        {
                            wonReels++;
                            if (lot1 == 3)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 3)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 3)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if ((lot1 == 4) || (lot2 == 4) || (lot3 == 4))
                        {
                            wonReels++;
                            if (lot1 == 4)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 4)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 4)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
            }

            switch (guess3)
            {
                case 1:
                    {
                        if ((lot1 == 1) || (lot2 == 1) || (lot3 == 1))
                        {
                            wonReels++;
                            if (lot1 == 1)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 1)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 1)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if ((lot1 == 2) || (lot2 == 2) || (lot3 == 2))
                        {
                            wonReels++;
                            if (lot1 == 2)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 2)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 2)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if ((lot1 == 3) || (lot2 == 3) || (lot3 == 3))
                        {
                            wonReels++;
                            if (lot1 == 3)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 3)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 3)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if ((lot1 == 4) || (lot2 == 4) || (lot3 == 4))
                        {
                            wonReels++;
                            if (lot1 == 4)
                            {
                                lot1 = 0;
                            }
                            else if (lot2 == 4)
                            {
                                lot2 = 0;
                            }
                            else if (lot3 == 4)
                            {
                                lot3 = 0;
                            }
                        }
                        break;
                    }
            }

            if (wonReels == 0)
            {
                labelResult.Text = LOSS;
            }
            else if (wonReels == 1)
            {
                labelResult.Text = SW;
            }
            else if (wonReels == 2)
            {
                labelResult.Text = DW;
            }
            else if (wonReels == 3)
            {
                labelResult.Text = TW;
            }
            else
            {
                labelResult.Text = "Something screwed up";
            }
            if (perfectWin)
            {
                labelResult.Text = PW;
            }
        }
    }
}
