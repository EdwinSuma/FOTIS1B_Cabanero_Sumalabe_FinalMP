
namespace FOTIS1B_Cabanero_Sumalabe_FinalMP
{
    partial class helpScreen
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
            this.returntoMenubutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returntoMenubutton
            // 
            this.returntoMenubutton.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.returntomenubutton2;
            this.returntoMenubutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returntoMenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returntoMenubutton.Location = new System.Drawing.Point(12, 449);
            this.returntoMenubutton.Name = "returntoMenubutton";
            this.returntoMenubutton.Size = new System.Drawing.Size(101, 27);
            this.returntoMenubutton.TabIndex = 0;
            this.returntoMenubutton.UseVisualStyleBackColor = true;
            this.returntoMenubutton.Click += new System.EventHandler(this.returntoMenubutton_Click);
            // 
            // helpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FOTIS1B_Cabanero_Sumalabe_FinalMP.Properties.Resources.MechanicsScreen;
            this.ClientSize = new System.Drawing.Size(828, 506);
            this.Controls.Add(this.returntoMenubutton);
            this.Name = "helpScreen";
            this.Text = "Mechanics Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameScreen_FormClosing);
            this.Load += new System.EventHandler(this.helpScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returntoMenubutton;
    }
}