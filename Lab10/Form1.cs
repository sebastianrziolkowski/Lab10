using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int rangeFrom;
        private int rangeTo;
        private static string GuessRandomNumberLabel;

        public void setUpVariables()
        {
            randomNumber = 0;
            rangeFrom = 0;
            rangeTo = 0;
            GuessRandomNumberLabel = "Zgadywana liczba z przedzialu";
            greenBox1.Visible = true;
            greenBox2.Visible = true;
            greenBox3.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;

            randomFrom.Text = "1";
            randomTo.Text = "10";
            numberGuess.Text = "";
        }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            setUpVariables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumberGuess;

            if (int.TryParse(numberGuess.Text, out randomNumberGuess))
            {
               if(randomNumber == randomNumberGuess)
                {
                    MessageBox.Show("You win! Great guess.", "Congratulation!.",
                        MessageBoxButtons.OK);
                    setUpVariables();
                }

                else
                {
                    Console.WriteLine("Try again.");

                    if(greenBox3.Visible == true)
                    {
                        greenBox3.Visible = false;
                        MessageBox.Show("You have only 2 chance left", "Wrong guess.",
                                 MessageBoxButtons.OK);
                    }
                    else if(greenBox2.Visible == true)
                    {
                        MessageBox.Show("You have only 1 chance left", "Wrong guess.",
                            MessageBoxButtons.OK);
                        greenBox2.Visible = false;
                    }
                    else
                    {
                        greenBox1.Visible = false;
                        MessageBox.Show("You lost! Try again.", "Wrong guess.",
                            MessageBoxButtons.OK);
                        setUpVariables();
                    }

                }
            }
            else
            {
                MessageBox.Show("Wrong input.", "Error.",
                    MessageBoxButtons.OK);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void randomFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (int.TryParse(randomFrom.Text, out rangeFrom) && int.TryParse(randomTo.Text, out rangeTo)
                && rangeFrom <= rangeTo)
            {
                randomNumber = new Random().Next(rangeFrom, rangeTo);
                panel1.Visible = false;
                panel2.Visible = true;
                RandomNumberLabel.Text = GuessRandomNumberLabel + " [" + rangeFrom + ", " + rangeTo + "]";
            }
            else
            {
                MessageBox.Show("Wrong input.", "Error.",
                    MessageBoxButtons.OK);
            }
        }

        private void rESETUJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setUpVariables();
        }

        private void numberGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void zAKOŃCZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
