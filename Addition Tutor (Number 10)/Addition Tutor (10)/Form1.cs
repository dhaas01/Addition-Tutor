using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor__10_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int random1;
        int random2;
        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            int answer;
            int userInput;
            questionLabel.Text = random1 + "+" + random2 + "= ?";
            answer = random1 + random2;
            if (int.TryParse(answerTextBox.Text, out userInput))
            {
                if (userInput == answer)
                {
                    checkAnswerLabel.Text = "Your answer is correct.";
                }
                else
                {
                    checkAnswerLabel.Text = "Your answer is incorrect. The correct answer is: " + answer;
                }
            }  
            else
            {
                MessageBox.Show ("Invalid input. Please enter an integer.");
            }
            GenerateRandomNumber();
            answerTextBox.Text = "";
            answerTextBox.Focus();
        } 

        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            random1 = rand.Next(400) + 101;
            random2 = rand.Next(400) + 101;
            questionLabel.Text = random1 + "+" + random2 + "= ?";
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
