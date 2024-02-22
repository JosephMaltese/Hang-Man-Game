using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman__Culminating
{
    public partial class Form1 : Form
    {
        char guess;
        int wordLen;
        char[] hiddenWord = new char[100];
        char[] dashes = new char[100];
        int checkIfCorrect = 0;
        int lives = 6;
        string guesstheword;
        string temp;




        public Form1()
        {
            InitializeComponent();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            btnConfirm.Visible = false;
            txtGuess.Visible = false;
            btnEnd.Visible = false;
            lblOut.Visible = false;
            lblPicture.Visible = false;
            lblGuessTheWord.Visible = false;

            lblPicture.Visible = false;
            lblPicture2.Visible = false;
            lblPicture3.Visible = false;
            lblPicture4.Visible = false;
            lblPicture5.Visible = false;
            lblPicture6.Visible = false;
            lblPicture7.Visible = false;

            lblinstructions.Text = "You are given a random word that you must guess. The word is hidden by a number of dashes that indicate the length of the word.\n\nYou can guess individual letters in the word. Correctly guessed letters will replace dashes in the word in the location(s) where they exist.\n\nIf a letter is guessed incorrectly, an extra part of the hangman will be drawn. When the full hangman is drawn, you have run out of guesses, and you lose the game.\n\nAfter each time a letter is guessed, you have the option to guess the word. If you guess correctly, you win the game. If the word is guessed incorrectly, you lose the game, no matter how many lives you have remaining.\n\nPress start whenever you are ready to play. ";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            txtGuess.Visible = true;
            lblOut.Visible = true;
            lblPicture.Visible = true;
            btnConfirm.Visible = true;
            btnEnd.Visible = true;
            lblGuessTheWord.Visible = true;
            lblTitle.Visible = false;
            lblinstructions.Visible = false;
            lblRules.Visible = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;

            btnConfirm.Enabled = false;
            txtGuess.Enabled = false;
            btnStart.Visible = false;

            txtGuess.Text = "";

            lblPicture.Text ="   ______________\n" + "  |              |\n" + "  |              |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__" ;
            lblPicture2.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            lblPicture3.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |              |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            lblPicture4.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |             /|\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            lblPicture5.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |             /|\\ \n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            lblPicture6.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |             /|\\ \n" + "  |             /\n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            lblPicture7.Text = "   ______________\n" + "  |              |\n" + "  |              |\n" + "  |              O\n" + "  |             /|\\ \n" + "  |             / \\ \n" + "  |\n" + "  |\n" + "  |\n" + "  |\n" + "__|__";
            // erase this lol
            
            lblPicture2.Visible = false;
            lblPicture3.Visible = false;
            lblPicture4.Visible = false;
            lblPicture5.Visible = false;
            lblPicture6.Visible = false;
            lblPicture7.Visible = false;
            

            StreamReader file = new StreamReader(@"C:\Users\joesa\OneDrive\Documents\Visual Studio 2019\Projects\files\marnHangman.txt");


            Random randNum = new Random();
            string[] words = new string[100];
            int x;
            string word;
            int count = 0;
            lives = 6;



            string guess;

            word = file.ReadLine();

            while (word != null)
            {
                words[count] = word;
                count++;
                word = file.ReadLine();
            }

            x = randNum.Next(0, count);

            temp = words[x];

            //lblOut.Text = temp + "\n";
            lblOut.Text = "Lives: " + lives + "\n";

            wordLen = temp.Length;

            for (int i = 0; i < wordLen; i++)
            {
                hiddenWord[i] = Convert.ToChar(temp.Substring(i, 1));
            }

            for (int i = 0; i < wordLen; i++)
            {
                dashes[i] = '-';
                lblOut.Text += dashes[i];
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            guess = 'a';

            check(guess);


            button1.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {

            guess = 'b';

            check(guess);


            button2.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            guess = 'c';

            check(guess);


            button3.Enabled = false;

            checkLives();
            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            guess = 'd';

            check(guess);


            button4.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            guess = 'e';

            check(guess);


            button5.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            guess = 'f';

            check(guess);


            button6.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            guess = 'g';

            check(guess);


            button7.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            guess = 'h';

            check(guess);


            button8.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            guess = 'i';

            check(guess);


            button9.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            guess = 'j';

            check(guess);


            button10.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }


        }

        private void Button11_Click(object sender, EventArgs e)
        {
            guess = 'k';

            check(guess);


            button11.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            guess = 'l';

            check(guess);


            button12.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            guess = 'm';

            check(guess);


            button13.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            guess = 'n';

            check(guess);


            button14.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            guess = 'o';

            check(guess);


            button15.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            guess = 'p';

            check(guess);


            button16.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            guess = 'q';

            check(guess);


            button17.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            guess = 'r';

            check(guess);


            button18.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            guess = 's';

            check(guess);


            button19.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            guess = 't';

            check(guess);


            button20.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            guess = 'u';

            check(guess);


            button21.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button22_Click(object sender, EventArgs e)
        {
            guess = 'v';

            check(guess);


            button22.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button23_Click(object sender, EventArgs e)
        {
            guess = 'w';

            check(guess);


            button23.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            guess = 'x';

            check(guess);


            button24.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button25_Click(object sender, EventArgs e)
        {
            guess = 'y';

            check(guess);


            button25.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void Button26_Click(object sender, EventArgs e)
        {
            guess = 'z';

            check(guess);


            button26.Enabled = false;

            checkLives();

            if (lives != 0)
            {
                //guessWord();
            }

        }

        private void check(char a)
        {
            lblOut.Text = "";
            checkIfCorrect = 0;

            for (int i = 0; i < wordLen; i++)
            {

                if (a == hiddenWord[i])
                {
                    dashes[i] = a;
                    checkIfCorrect++;
                }

            }

            if (checkIfCorrect == 0)
            {
                lblOut.Text = "Incorrect! The letter '" + a + "' is not in the word.\n";
                lives--;
            }
            else
            {
                lblOut.Text = "Correct! The letter '" + a + "' is in the word.\n";
                txtGuess.Enabled = true;
            }

            if (lives == 5)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = true;
                lblPicture3.Visible = false;
                lblPicture4.Visible = false;
                lblPicture5.Visible = false;
                lblPicture6.Visible = false;
                lblPicture7.Visible = false;

            }
            else if (lives == 4)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = false;
                lblPicture3.Visible = true;
                lblPicture4.Visible = false;
                lblPicture5.Visible = false;
                lblPicture6.Visible = false;
                lblPicture7.Visible = false;
            }
            else if (lives == 3)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = false;
                lblPicture3.Visible = false;
                lblPicture4.Visible = true;
                lblPicture5.Visible = false;
                lblPicture6.Visible = false;
                lblPicture7.Visible = false;
            }
            else if (lives == 2)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = false;
                lblPicture3.Visible = false;
                lblPicture4.Visible = false;
                lblPicture5.Visible = true;
                lblPicture6.Visible = false;
                lblPicture7.Visible = false;
            }
            else if (lives ==1)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = false;
                lblPicture3.Visible = false;
                lblPicture4.Visible = false;
                lblPicture5.Visible = false;
                lblPicture6.Visible = true;
                lblPicture7.Visible = false;
            }
            else if (lives <= 0)
            {
                lblPicture.Visible = false;
                lblPicture2.Visible = false;
                lblPicture3.Visible = false;
                lblPicture4.Visible = false;
                lblPicture5.Visible = false;
                lblPicture6.Visible = false;
                lblPicture7.Visible = true;
            }

            for (int i = 0; i < wordLen; i++)
            {
                lblOut.Text += dashes[i];
            }
        }

        private void checkLives()
        {
            if (lives <= 0)
            {
                btnStart.Text = "Play Again";
                lblOut.Text = "You Lose! You ran out of guesses.\n\nThe correct word was " + temp + ".\n";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                btnConfirm.Enabled = false;
                txtGuess.Enabled = false;
                btnStart.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            guesstheword = txtGuess.Text;
            guesstheword = guesstheword.ToLower();

            if (guesstheword == temp)
            {
                lblOut.Text = "Correct! The word is " + temp + ". You Win!";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                btnConfirm.Enabled = false;
                txtGuess.Enabled = false;
                btnStart.Visible = true;
            }
            else
            {
                lblOut.Text = "Incorrect! The word is " + temp + ". You Lose.";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                btnConfirm.Enabled = false;
                txtGuess.Enabled = false;
                btnStart.Visible = true;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
