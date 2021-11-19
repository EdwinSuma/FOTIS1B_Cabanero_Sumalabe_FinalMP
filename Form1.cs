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
    public partial class Form1 : Form
    {
        gameScreen ingamescreen = new gameScreen();
        helpScreen inhelpscreen = new helpScreen();

        public Form1()
        {
            InitializeComponent();
        }

        private void startgamebutton_Click(object sender, EventArgs e)
        {
            ingamescreen.Show(); 
        }

        private void mechanicsShow(object sender, EventArgs e)
        {
            inhelpscreen.Show();
        }

        private void exitgamemainbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
