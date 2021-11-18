
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
            this.punchbutton = new System.Windows.Forms.Button();
            this.counterbutton = new System.Windows.Forms.Button();
            this.blockbutton = new System.Windows.Forms.Button();
            this.endturnbutton = new System.Windows.Forms.Button();
            this.quitgamebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // punchbutton
            // 
            this.punchbutton.Location = new System.Drawing.Point(51, 415);
            this.punchbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.punchbutton.Name = "punchbutton";
            this.punchbutton.Size = new System.Drawing.Size(62, 27);
            this.punchbutton.TabIndex = 3;
            this.punchbutton.Text = "Punch";
            this.punchbutton.UseVisualStyleBackColor = true;
            this.punchbutton.Click += new System.EventHandler(this.punchbutton_Click);
            // 
            // counterbutton
            // 
            this.counterbutton.Location = new System.Drawing.Point(299, 415);
            this.counterbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.counterbutton.Name = "counterbutton";
            this.counterbutton.Size = new System.Drawing.Size(62, 27);
            this.counterbutton.TabIndex = 4;
            this.counterbutton.Text = "Counter";
            this.counterbutton.UseVisualStyleBackColor = true;
            this.counterbutton.Click += new System.EventHandler(this.counterbutton_Click);
            // 
            // blockbutton
            // 
            this.blockbutton.Location = new System.Drawing.Point(566, 415);
            this.blockbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.blockbutton.Name = "blockbutton";
            this.blockbutton.Size = new System.Drawing.Size(62, 27);
            this.blockbutton.TabIndex = 5;
            this.blockbutton.Text = "Block";
            this.blockbutton.UseVisualStyleBackColor = true;
            this.blockbutton.Click += new System.EventHandler(this.blockbutton_Click);
            // 
            // endturnbutton
            // 
            this.endturnbutton.BackColor = System.Drawing.Color.Maroon;
            this.endturnbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.EndTurnButton;
            this.endturnbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endturnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endturnbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endturnbutton.Location = new System.Drawing.Point(694, 318);
            this.endturnbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endturnbutton.Name = "endturnbutton";
            this.endturnbutton.Size = new System.Drawing.Size(118, 38);
            this.endturnbutton.TabIndex = 6;
            this.endturnbutton.UseVisualStyleBackColor = false;
            this.endturnbutton.Click += new System.EventHandler(this.endturnbutton_Click);
            // 
            // quitgamebutton
            // 
            this.quitgamebutton.Location = new System.Drawing.Point(10, 460);
            this.quitgamebutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quitgamebutton.Name = "quitgamebutton";
            this.quitgamebutton.Size = new System.Drawing.Size(62, 27);
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
            this.timer.Location = new System.Drawing.Point(754, 277);
            this.timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(33, 15);
            this.timer.TabIndex = 8;
            this.timer.Text = "Timer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.Enemy;
            this.pictureBox2.Location = new System.Drawing.Point(137, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.Ready;
            this.pictureBox1.Location = new System.Drawing.Point(464, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(346, 305);
            this.playerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(67, 15);
            this.playerName.TabIndex = 12;
            this.playerName.Text = "Player Name:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 344);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(324, 59);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(237, 23);
            this.progressBar2.TabIndex = 14;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.GameScreennnn;
            this.ClientSize = new System.Drawing.Size(813, 506);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.quitgamebutton);
            this.Controls.Add(this.endturnbutton);
            this.Controls.Add(this.blockbutton);
            this.Controls.Add(this.counterbutton);
            this.Controls.Add(this.punchbutton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Button punchbutton;
        private System.Windows.Forms.Button counterbutton;
        private System.Windows.Forms.Button blockbutton;
        private System.Windows.Forms.Button endturnbutton;
        private System.Windows.Forms.Button quitgamebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}