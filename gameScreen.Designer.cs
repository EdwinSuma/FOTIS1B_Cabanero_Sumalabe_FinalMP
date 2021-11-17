
namespace FOTIS1B_Cabanero_Sumalabe_FinalMP
{
    partial class gameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StaminaLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.EnemyHPLabel = new System.Windows.Forms.Label();
            this.punchbutton = new System.Windows.Forms.Button();
            this.counterbutton = new System.Windows.Forms.Button();
            this.blockbutton = new System.Windows.Forms.Button();
            this.endturnbutton = new System.Windows.Forms.Button();
            this.quitgamebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Winner = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaminaLabel
            // 
            this.StaminaLabel.AutoSize = true;
            this.StaminaLabel.Location = new System.Drawing.Point(13, 252);
            this.StaminaLabel.Name = "StaminaLabel";
            this.StaminaLabel.Size = new System.Drawing.Size(51, 13);
            this.StaminaLabel.TabIndex = 0;
            this.StaminaLabel.Text = "Stamina: ";
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Location = new System.Drawing.Point(190, 252);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(28, 13);
            this.HPLabel.TabIndex = 1;
            this.HPLabel.Text = "HP: ";
            // 
            // EnemyHPLabel
            // 
            this.EnemyHPLabel.AutoSize = true;
            this.EnemyHPLabel.Location = new System.Drawing.Point(553, 13);
            this.EnemyHPLabel.Name = "EnemyHPLabel";
            this.EnemyHPLabel.Size = new System.Drawing.Size(63, 13);
            this.EnemyHPLabel.TabIndex = 2;
            this.EnemyHPLabel.Text = "Enemy HP: ";
            // 
            // punchbutton
            // 
            this.punchbutton.Location = new System.Drawing.Point(49, 312);
            this.punchbutton.Name = "punchbutton";
            this.punchbutton.Size = new System.Drawing.Size(75, 23);
            this.punchbutton.TabIndex = 3;
            this.punchbutton.Text = "Punch";
            this.punchbutton.UseVisualStyleBackColor = true;
            this.punchbutton.Click += new System.EventHandler(this.punchbutton_Click);
            // 
            // counterbutton
            // 
            this.counterbutton.Location = new System.Drawing.Point(347, 312);
            this.counterbutton.Name = "counterbutton";
            this.counterbutton.Size = new System.Drawing.Size(75, 23);
            this.counterbutton.TabIndex = 4;
            this.counterbutton.Text = "Counter";
            this.counterbutton.UseVisualStyleBackColor = true;
            this.counterbutton.Click += new System.EventHandler(this.counterbutton_Click);
            // 
            // blockbutton
            // 
            this.blockbutton.Location = new System.Drawing.Point(667, 312);
            this.blockbutton.Name = "blockbutton";
            this.blockbutton.Size = new System.Drawing.Size(75, 23);
            this.blockbutton.TabIndex = 5;
            this.blockbutton.Text = "Block";
            this.blockbutton.UseVisualStyleBackColor = true;
            this.blockbutton.Click += new System.EventHandler(this.blockbutton_Click);
            // 
            // endturnbutton
            // 
            this.endturnbutton.Location = new System.Drawing.Point(347, 399);
            this.endturnbutton.Name = "endturnbutton";
            this.endturnbutton.Size = new System.Drawing.Size(75, 23);
            this.endturnbutton.TabIndex = 6;
            this.endturnbutton.Text = "End Turn";
            this.endturnbutton.UseVisualStyleBackColor = true;
            this.endturnbutton.Click += new System.EventHandler(this.endturnbutton_Click);
            // 
            // quitgamebutton
            // 
            this.quitgamebutton.Location = new System.Drawing.Point(12, 399);
            this.quitgamebutton.Name = "quitgamebutton";
            this.quitgamebutton.Size = new System.Drawing.Size(75, 23);
            this.quitgamebutton.TabIndex = 7;
            this.quitgamebutton.Text = "Quit Game";
            this.quitgamebutton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(677, 252);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(33, 13);
            this.timer.TabIndex = 8;
            this.timer.Text = "Timer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.Enemy;
            this.pictureBox2.Location = new System.Drawing.Point(49, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.Ready;
            this.pictureBox1.Location = new System.Drawing.Point(367, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Winner
            // 
            this.Winner.Location = new System.Drawing.Point(355, 54);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(261, 73);
            this.Winner.TabIndex = 11;
            this.Winner.Text = "Winner";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(459, 287);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(70, 13);
            this.playerName.TabIndex = 12;
            this.playerName.Text = "Player Name:";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.quitgamebutton);
            this.Controls.Add(this.endturnbutton);
            this.Controls.Add(this.blockbutton);
            this.Controls.Add(this.counterbutton);
            this.Controls.Add(this.punchbutton);
            this.Controls.Add(this.EnemyHPLabel);
            this.Controls.Add(this.HPLabel);
            this.Controls.Add(this.StaminaLabel);
            this.Name = "gameScreen";
            this.Text = "Game Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mechanicsScreen_FormClosing);
            this.Load += new System.EventHandler(this.gameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaminaLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Label EnemyHPLabel;
        private System.Windows.Forms.Button punchbutton;
        private System.Windows.Forms.Button counterbutton;
        private System.Windows.Forms.Button blockbutton;
        private System.Windows.Forms.Button endturnbutton;
        private System.Windows.Forms.Button quitgamebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.Label playerName;
    }
}