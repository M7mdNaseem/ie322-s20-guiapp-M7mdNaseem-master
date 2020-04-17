namespace Naseem_1847585
{
    partial class FrmRandom
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
            this.btnGRC = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRN = new System.Windows.Forms.Button();
            this.lblRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGRC
            // 
            this.btnGRC.Location = new System.Drawing.Point(217, 37);
            this.btnGRC.Name = "btnGRC";
            this.btnGRC.Size = new System.Drawing.Size(303, 51);
            this.btnGRC.TabIndex = 0;
            this.btnGRC.Text = "Generate Random Color";
            this.btnGRC.UseVisualStyleBackColor = true;
            this.btnGRC.Click += new System.EventHandler(this.btnGRC_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(599, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRN
            // 
            this.btnRN.Location = new System.Drawing.Point(149, 328);
            this.btnRN.Name = "btnRN";
            this.btnRN.Size = new System.Drawing.Size(193, 26);
            this.btnRN.TabIndex = 2;
            this.btnRN.Text = "Random Number";
            this.btnRN.UseVisualStyleBackColor = true;
            this.btnRN.Click += new System.EventHandler(this.btnRN_Click);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(356, 210);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(35, 13);
            this.lblRGB.TabIndex = 3;
            this.lblRGB.Text = "R-G-B";
            this.lblRGB.Click += new System.EventHandler(this.lblRGB_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.btnRN);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGRC);
            this.Name = "FrmRandom";
            this.Text = "FrmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGRC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRN;
        private System.Windows.Forms.Label lblRGB;
    }
}