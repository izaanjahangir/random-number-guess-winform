using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int randomNumber;
        bool isGameEnded = false;

        public Form1()
        {
            InitializeComponent();
            initGame();
            
   
        }

        void initGame() {
            randomNumber = getRandomNumber();
            lb_answer.Visible = false;
            tb_guess.ReadOnly = false;
            isGameEnded = false;
            btn_submit.Text = "Submit";
            tb_guess.Clear();

            Console.WriteLine("Random number is: " + randomNumber);
        }

        void endGame() {
            tb_guess.ReadOnly = true;
            isGameEnded = true;
            btn_submit.Text = "Play Again";
        }

        int getRandomNumber() {
            var rand = new Random();
            return rand.Next(0, 10);
        }

        private void showError(string errorMessage) {
            lb_answer.Text = errorMessage;
            lb_answer.ForeColor = Color.Red;
            lb_answer.Visible = true;
        }

        private void showSuccess(string successMessage)
        {
            lb_answer.Text = successMessage;
            lb_answer.ForeColor = Color.Green;
            lb_answer.Visible = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(isGameEnded)
            {
                initGame();
                return;
            }
            string guess = tb_guess.Text;
            int guessedNumber;
            bool isNumber = int.TryParse(guess, out guessedNumber);

            if (string.IsNullOrEmpty(guess))
            {
                showError("Come on, first guess something");
                return;
            }

            if(!isNumber)
            {
                showError("Please write a valid number");
                return;
            } 

            Console.WriteLine("randomNumber first: " + randomNumber);
            Console.WriteLine("guess: " + guess);
            Console.WriteLine("guessedNumber: " + guessedNumber);
            Console.WriteLine("randomNumber: " + randomNumber);

            if (guessedNumber == randomNumber)
            {
                showSuccess("Damn, your guess is soo good");
                endGame();
            }
            else if(guessedNumber < randomNumber)
            {
                showError("Nope, increase your guess");
            }
            else if (guessedNumber > randomNumber)
            {
                showError("Nope, decrease your guess");
            }
            else
            {
                showError("Nope, try again");
            }
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
