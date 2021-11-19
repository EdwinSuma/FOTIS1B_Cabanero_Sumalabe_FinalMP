
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // punchbutton
            // 
            this.punchbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.punchbutton;
            this.punchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.punchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punchbutton.Location = new System.Drawing.Point(119, 404);
            this.punchbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.punchbutton.Name = "punchbutton";
            this.punchbutton.Size = new System.Drawing.Size(110, 38);
            this.punchbutton.TabIndex = 3;
            this.punchbutton.UseVisualStyleBackColor = true;
            this.punchbutton.Click += new System.EventHandler(this.punchbutton_Click);
            // 
            // counterbutton
            // 
            this.counterbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.counterbutton;
            this.counterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.counterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.counterbutton.Location = new System.Drawing.Point(351, 404);
            this.counterbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.counterbutton.Name = "counterbutton";
            this.counterbutton.Size = new System.Drawing.Size(120, 38);
            this.counterbutton.TabIndex = 4;
            this.counterbutton.UseVisualStyleBackColor = true;
            this.counterbutton.Click += new System.EventHandler(this.counterbutton_Click);
            // 
            // blockbutton
            // 
            this.blockbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.blockbutton;
            this.blockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockbutton.Location = new System.Drawing.Point(600, 404);
            this.blockbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.blockbutton.Name = "blockbutton";
            this.blockbutton.Size = new System.Drawing.Size(115, 38);
            this.blockbutton.TabIndex = 5;
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
            this.quitgamebutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.returntomenubutton;
            this.quitgamebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitgamebutton.Location = new System.Drawing.Point(11, 448);
            this.quitgamebutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quitgamebutton.Name = "quitgamebutton";
            this.quitgamebutton.Size = new System.Drawing.Size(111, 33);
            this.quitgamebutton.TabIndex = 7;
            this.quitgamebutton.UseVisualStyleBackColor = true;
            this.quitgamebutton.Click += new System.EventHandler(this.quitgamebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(682, 22);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(446, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 14;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(715, 22);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(19, 15);
            this.timeLbl.TabIndex = 15;
            this.timeLbl.Text = "20";
            this.timeLbl.Visible = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.GameScreennnnn;
            this.ClientSize = new System.Drawing.Size(813, 506);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLbl;
    }
}