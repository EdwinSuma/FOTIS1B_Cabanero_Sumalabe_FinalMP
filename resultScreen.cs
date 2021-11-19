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
    public partial class resultScreen : Form
    {
        public resultScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            gameScreen game = new gameScreen();
            game.Show();
            
        }

        private void resultScreen_Load(object sender, EventArgs e)
        {
            if(gameScreen.gameResult == "win")
            {
                pictureBox3.BackgroundImage = Properties.Resources.ResultsWin;
            }
            else if (gameScreen.gameResult == "draw")
            {
                pictureBox3.BackgroundImage = Properties.Resources.ResultsDraw;
            }
            else if (gameScreen.gameResult == "lose")
            {
                pictureBox3.BackgroundImage = Properties.Resources.ResultsLose;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

        }
    }
}
