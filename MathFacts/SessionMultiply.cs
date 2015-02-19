using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathFacts
{
    public partial class SessionMultiply : Form
    {
        public SessionMultiply()
        {
            InitializeComponent();
        }

        private void SessionMultiply_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Enable 'Stop' button
            stopButton.Enabled = true;

            // Hide 'Close' button.
            closeButton.Visible = false;

            // Hide instructions.
            labelInstructions.Visible = false;
            labelInstructionsStart.Visible = false;

            // Clear old score and reposition label.
            scoreLabel.Location = new System.Drawing.Point(344, 218);
            scoreLabel.Text = "Score:";

            // Put cursor in input box
            answerBox.Focus();
            answerBox.TabIndex = 1;

            // Disable 'Start' button
            startButton.Enabled = false;

            // Initialize score
            MultProblem.SessionScore = 0;
            MultProblem.SessionTotal = 0;
            updateScore(false);

            // Set up for first problem.
            answerBox.Visible = true;
            answerBox.Enabled = true;
            factorLabel1.Visible = true;

            // First problem
            multiplicationProblem();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Clear problem
            factorLabel1.Visible = false;
            answerBox.Clear();
            answerBox.Enabled = false;
            answerBox.Visible = false;
            buttonNext.Visible = false;
            correctLabel.Visible = false;

            // Show final score
            updateScore(true);  // True = final score.

            // Enable 'Close' button
            closeButton.Visible = true;

            // Enable 'Start' button and disable stop button
            startButton.Enabled = true;
            stopButton.Enabled = false;

        }
    
        private void updateScore(bool final)
        {
            int answersCorrect = MultProblem.SessionScore;
            int answersTotal = MultProblem.SessionTotal;

            if (final == true)
            {
                scoreLabel.Location = new System.Drawing.Point(144, 118);
                scoreLabel.Text = "Your final score is: " + answersCorrect.ToString("D") + " / " + answersTotal.ToString("D");
            }
            else
            {
                scoreLabel.Text = "Score: " + answersCorrect.ToString("D") + " / " + answersTotal.ToString("D");
            }
        }

        private void multiplicationProblem()
        {
            // Clear Correct/Incorrect label
            correctLabel.Visible = false;

            // Generate random factor pair that meets settings requirements
                        
            // Factor 1 is chosen randomly from the special factors chosen in the session configuration. 
            Random rnd1 = new Random();
            MultProblem.MultFactor1 = MultProblem.SpecFactors[rnd1.Next(MultProblem.SpecFactors.Length)];

            // Factor 2 is randomly chosen between 0 and second factor limit
            Random rnd2 = new Random();
            MultProblem.MultFactor2 = rnd2.Next(MultProblem.SecondFactorLimit + 1);

            // Display problem
            factorLabel1.Text = " " + MultProblem.MultFactor1.ToString("D") + "x" + MultProblem.MultFactor2.ToString("D");

            // Calculate correct answer
            MultProblem.MultAnswer = MultProblem.MultFactor1 * MultProblem.MultFactor2;
                        
        }

        private void answerBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Ignore input to text box until the user presses the Enter key.
            if(e.KeyValue == 13)
            {
                try
                {
                    // Check answer against correct.
                    if ((Convert.ToInt16(answerBox.Text)) == MultProblem.MultAnswer)
                    {
                        correctLabel.ForeColor = Color.Green;
                        correctLabel.Text = "Yes!";
                        MultProblem.SessionScore++;
                    }
                    else
                    {
                        correctLabel.ForeColor = Color.Red;
                        correctLabel.Text = "Sorry, no!\nThe answer\n is " + MultProblem.MultAnswer + ".";
                    }

                    // Update score total.
                    MultProblem.SessionTotal++;

                    updateScore(false);

                    buttonNext.Focus();
                }
                // Catch an exception for non-integer input.
                // Notifies user, allows input retry, does not affect score.
                catch (FormatException error)   
                {
                    answerBox.Clear();
                    correctLabel.ForeColor = Color.Red;
                    correctLabel.Text = "Please input a number.";
                }
                correctLabel.Visible = true;
                buttonNext.Visible = true;

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Put cursor in input box
            answerBox.Focus();
            answerBox.TabIndex = 1;

            // Set up for next problem.
            answerBox.Visible = true;
            answerBox.Enabled = true;
            correctLabel.Visible = false;
            factorLabel1.Visible = true;
            buttonNext.Visible = false;
            answerBox.Clear();

            // next problem
            multiplicationProblem();
        }
 
    }
}
