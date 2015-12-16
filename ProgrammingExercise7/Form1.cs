using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void buttonGuess_Click(object sender, EventArgs e)
        {

            Random RNG = new Random();
            int guessWin = RNG.Next(1, 11);
            int guess = Convert.ToInt32(textBoxGuess.Text);
            if (guess == guessWin)
            {
                labelResult.Text = "Your guess was exactly right!";
            }
            else if (guess > guessWin)
            {
                labelResult.Text = String.Format("Your guess was too high. Answer: {0}", guessWin);
            }
            else if (guess < guessWin)
            {
                labelResult.Text = String.Format("Your guess was too low. Answer: {0}", guessWin);
            }
        }
    }
}
