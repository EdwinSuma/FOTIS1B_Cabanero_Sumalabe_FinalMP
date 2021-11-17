using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Cabanero_Sumalabe_FinalMP
{
    public partial class gameScreen : Form
    {
        public int rounds = 12;
        public int timePerRound = 21;
        string[] AIChoice = { "punch", "counter", "block", "punch", "block", "counter" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string PlayerChoice;
        int playerWins = 0;
        int AIWins = 0;

        class Boxer
        {
            public int HP;
            public int HPMax;
            public int Stamina;
            public int StaminaMax;


        }
        public gameScreen()
        {
            InitializeComponent();
        }

        private void mechanicsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void gameScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            PlayerChoice = "none";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timePerRound--;
            timer.Text = "Timer:  " + Convert.ToString(timePerRound);
            if (timePerRound < 1)
            {
                timer1.Enabled = false;
                timePerRound = 21;
                randomNumber = rnd.Next(0, 5);
                command = AIChoice[randomNumber];

                switch (command)
                {
                    case "punch":
                        pictureBox2.Image = Properties.Resources.Punch;
                        break;

                    case "counter":
                        pictureBox2.Image = Properties.Resources.Counter;
                        break;

                    case "block":
                        pictureBox2.Image = Properties.Resources.Block;
                        break;

                    default:
                        break;
                }
                if (rounds > 1)
                {
                    checkGame();
                }
                else
                {
                    decisionEngine();
                }

                 void checkGame()
                {
                    int playerHP;
                    Boxer Player = new Boxer();
                    Boxer Enemy = new Boxer();
                    Player.HPMax = 1000;
                    Player.HP = 1000;
                    Enemy.HPMax = 1000;                                                                                    
                    Enemy.HP = 1000;


                    if (PlayerChoice == "punch" && command == "counter")
                    {
                        MessageBox.Show("AI Win");
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "counter" && command == "punch")
                    {
                        MessageBox.Show("Player Wins");
                        playerWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "counter" && command == "block")
                    {
                        MessageBox.Show("Mitigated Damage for AI");
                        playerWins++;
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "block" && command == "counter")
                    {
                        MessageBox.Show("Mitigated damage for player");
                        playerWins++;
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "punch" && command == "block")
                    {
                        MessageBox.Show("Mitigated Damage for AI");
                        playerWins++;
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "punch" && command == "punch")
                    {
                        MessageBox.Show("Equal damage to players");
                        playerWins++;
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "counter" && command == "counter")
                    {
                        MessageBox.Show("Randomize who wins");
                        playerWins++;
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "block" && command == "punch")
                    {
                        MessageBox.Show("Mitigated damage to player");
                        AIWins++;
                        rounds--;
                        nextRound();
                    }
                    else if (PlayerChoice == "block" && command == "block")
                    {
                        MessageBox.Show("No Damage for both players");
                        rounds--;
                        nextRound();
                    }
                }
                void decisionEngine ()
                {
                    if (playerWins > AIWins)
                    {
                        Winner.Text = playerName.Text + "Wins the game";
                    }
                    else
                    {
                        Winner.Text = "AI Wins the Game";
                    }    
                }
               void nextRound()
                {
                    PlayerChoice = "none";
                    pictureBox1.Image = Properties.Resources.Ready;
                    timer1.Enabled = true;
                    pictureBox2.Image = Properties.Resources.Enemy;
                }
            }
        }

        private void punchbutton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "punch";
            pictureBox1.Image = Properties.Resources.Punch;
        }

        private void counterbutton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "counter";
            pictureBox1.Image = Properties.Resources.Counter;
        }

        private void blockbutton_Click(object sender, EventArgs e)
        {
            PlayerChoice = "block";
            pictureBox1.Image = Properties.Resources.Block;
        }

        private void endturnbutton_Click(object sender, EventArgs e)
        {
            timePerRound = 0;
        }
    }
}
