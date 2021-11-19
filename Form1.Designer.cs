
namespace FOTIS1B_Cabanero_Sumalabe_FinalMP
{
    partial class Form1
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
            this.startgamebutton = new System.Windows.Forms.Button();
            this.mechanicsbutton = new System.Windows.Forms.Button();
            this.exitgamemainbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgamebutton
            // 
            this.startgamebutton.AutoSize = true;
            this.startgamebutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.startbutton;
            this.startgamebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startgamebutton.ForeColor = System.Drawing.Color.Maroon;
            this.startgamebutton.Location = new System.Drawing.Point(108, 174);
            this.startgamebutton.Name = "startgamebutton";
            this.startgamebutton.Size = new System.Drawing.Size(185, 58);
            this.startgamebutton.TabIndex = 0;
            this.startgamebutton.UseVisualStyleBackColor = true;
            this.startgamebutton.Click += new System.EventHandler(this.startgamebutton_Click);
            // 
            // mechanicsbutton
            // 
            this.mechanicsbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.mechanicsbuttonn;
            this.mechanicsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mechanicsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mechanicsbutton.ForeColor = System.Drawing.Color.Maroon;
            this.mechanicsbutton.Location = new System.Drawing.Point(108, 278);
            this.mechanicsbutton.Name = "mechanicsbutton";
            this.mechanicsbutton.Size = new System.Drawing.Size(185, 61);
            this.mechanicsbutton.TabIndex = 1;
            this.mechanicsbutton.UseVisualStyleBackColor = true;
            this.mechanicsbutton.Click += new System.EventHandler(this.mechanicsShow);
            // 
            // exitgamemainbutton
            // 
            this.exitgamemainbutton.BackColor = System.Drawing.Color.Maroon;
            this.exitgamemainbutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.exitgamebutton;
            this.exitgamemainbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitgamemainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitgamemainbutton.Location = new System.Drawing.Point(108, 389);
            this.exitgamemainbutton.Name = "exitgamemainbutton";
            this.exitgamemainbutton.Size = new System.Drawing.Size(185, 63);
            this.exitgamemainbutton.TabIndex = 2;
            this.exitgamemainbutton.UseVisualStyleBackColor = false;
            this.exitgamemainbutton.Click += new System.EventHandler(this.exitgamemainbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.TitleScreen;
            this.ClientSize = new System.Drawing.Size(398, 456);
            this.Controls.Add(this.exitgamemainbutton);
            this.Controls.Add(this.startgamebutton);
            this.Controls.Add(this.mechanicsbutton);
            this.Name = "Form1";
            this.Text = "Title Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startgamebutton;
        private System.Windows.Forms.Button mechanicsbutton;
        private System.Windows.Forms.Button exitgamemainbutton;
    }
}

