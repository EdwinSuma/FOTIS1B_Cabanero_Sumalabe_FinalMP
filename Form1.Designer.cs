
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startgamebutton
            // 
            this.startgamebutton.Location = new System.Drawing.Point(140, 100);
            this.startgamebutton.Name = "startgamebutton";
            this.startgamebutton.Size = new System.Drawing.Size(75, 23);
            this.startgamebutton.TabIndex = 0;
            this.startgamebutton.Text = "Start Game";
            this.startgamebutton.UseVisualStyleBackColor = true;
            this.startgamebutton.Click += new System.EventHandler(this.startgamebutton_Click);
            // 
            // mechanicsbutton
            // 
            this.mechanicsbutton.Location = new System.Drawing.Point(140, 210);
            this.mechanicsbutton.Name = "mechanicsbutton";
            this.mechanicsbutton.Size = new System.Drawing.Size(75, 23);
            this.mechanicsbutton.TabIndex = 1;
            this.mechanicsbutton.Text = "Mechanics";
            this.mechanicsbutton.UseVisualStyleBackColor = true;
            this.mechanicsbutton.Click += new System.EventHandler(this.mechanicsShow);
            // 
            // exitgamemainbutton
            // 
            this.exitgamemainbutton.Location = new System.Drawing.Point(140, 377);
            this.exitgamemainbutton.Name = "exitgamemainbutton";
            this.exitgamemainbutton.Size = new System.Drawing.Size(75, 23);
            this.exitgamemainbutton.TabIndex = 2;
            this.exitgamemainbutton.Text = "Quit Game";
            this.exitgamemainbutton.UseVisualStyleBackColor = true;
            this.exitgamemainbutton.Click += new System.EventHandler(this.exitgamemainbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitgamemainbutton);
            this.Controls.Add(this.mechanicsbutton);
            this.Controls.Add(this.startgamebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startgamebutton;
        private System.Windows.Forms.Button mechanicsbutton;
        private System.Windows.Forms.Button exitgamemainbutton;
        private System.Windows.Forms.Label label1;
    }
}

