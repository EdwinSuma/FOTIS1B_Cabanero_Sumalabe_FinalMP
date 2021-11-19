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
        public static string gameResult;

        public int rounds = 12;
        public int timePerRound = 21;
        string[] AIChoice = { "punch", "counter", "block", "punch", "block", "counter" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string PlayerChoice;

        Boxer Player = new Boxer();
        Boxer Enemy = new Boxer();

        class Boxer
        {
            int hp;
            int punch;

            public int HP { get { return hp; } set { hp = value; } }
            public int PunchDamage { get { return punch; } set { punch = value; } }
            public int CounterDamage { get; set; }
            public int BlockMitigation { get; set; }
            public int CounterBlock { get; set; }


            public int Punch(Boxer target)
            {
                target.HP -= PunchDamage;
                return hp;
            }
            public int Mitigate(Boxer target)
            {
                target.HP += this.BlockMitigation;
                return hp;
            }
            public int Counter(Boxer target)
            {
                target.HP -= this.CounterDamage;
                return hp;
            }
            public int CounterBlck(Boxer target)
            {
                target.HP -= this.CounterBlock;
                return hp;

            }
            public Boxer()
            {
                this.HP = 1000;
                this.PunchDamage = 83;
                this.CounterDamage = 166;
                this.BlockMitigation = 60;
                this.CounterBlock = 60;

            }
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
            PlayerChoice = "none";
            Winner.Visible = false;
            gameRun(Player, Enemy);
        }
        private void gameRun(Boxer Player, Boxer Enemy)
        {
            
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

            if (rounds > 0)
            {
                if (PlayerChoice == "punch" && command == "counter")
                {
                    Enemy.Counter(Player);
                    MessageBox.Show("AI Win, Player HP: " + Player.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "counter" && command == "punch")
                {
                    Player.Counter(Enemy);
                    MessageBox.Show("Player Wins, AI HP: " + Enemy.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "counter" && command == "block")
                {
                    Player.CounterBlck(Enemy);
                    MessageBox.Show("Mitigated Damage for AI, AI HP: " + Enemy.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "block" && command == "counter")
                {
                    Enemy.CounterBlck(Player);
                    MessageBox.Show("Mitigated damage for player, Player HP: " + Player.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "punch" && command == "block")
                {
                    Player.Punch(Enemy);
                    Enemy.Mitigate(Enemy);
                    MessageBox.Show("Mitigated Damage for AI, AI HP: " + Enemy.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "punch" && command == "punch")
                {

                    Player.Punch(Enemy);
                    Enemy.Punch(Player);
                    MessageBox.Show("Equal damage to players, AI HP: " + Enemy.HP.ToString() + "  Player HP: " + Player.HP.ToString());
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "counter" && command == "counter")
                {
                    randomNumber = rnd.Next(0, 100);
                    Console.WriteLine(randomNumber);
                    if (randomNumber >= 50)
                    {
                        MessageBox.Show("Player Wins");
                        Player.Counter(Enemy);
                        rounds--;
                        nextRound();
                        label1.Text = Player.HP.ToString();
                        label2.Text = Enemy.HP.ToString();
                    }
                    else if (randomNumber < 50)
                    {
                        MessageBox.Show("AI Wins");
                        Enemy.Counter(Player);
                        rounds--;
                        nextRound();
                        label1.Text = Player.HP.ToString();
                        label2.Text = Enemy.HP.ToString();
                    }
                }
                else if (PlayerChoice == "block" && command == "punch")
                {
                    MessageBox.Show("Mitigated damage to player");
                    Enemy.Punch(Player);
                    Player.Mitigate(Player);
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
                else if (PlayerChoice == "block" && command == "block")
                {
                    MessageBox.Show("No Damage for both players");
                    rounds--;
                    nextRound();
                    label1.Text = Player.HP.ToString();
                    label2.Text = Enemy.HP.ToString();
                }
            }
            else
            {
                if (Player.HP > Enemy.HP) //win
                {
                    Winner.Visible = true;
                    
                    gameResult = "Player Wins the game";

                    Console.WriteLine(gameResult);

                    this.Hide();
                    resultScreen result = new resultScreen();
                    result.Show();
                }
                else if (Player.HP == Enemy.HP)
                {
                    Winner.Visible = true;
                    Winner.Text = " DRAW!";

                }
                else //lose
                {
                    
                    Winner.Text = " AI Wins the Game";

                    gameResult = "AI Wins the Game";
                    Console.WriteLine(gameResult);
                    
                    this.Hide();
                    resultScreen result = new resultScreen();
                    result.Show(); 
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
            rounds--;
            gameRun(Player, Enemy);
        }

        private void quitgamebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

