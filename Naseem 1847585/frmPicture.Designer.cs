namespace Naseem_1847585
{
    partial class frmPicture
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
            this.btnImage2 = new System.Windows.Forms.Button();
            this.pictry = new System.Windows.Forms.PictureBox();
            this.btnImage1 = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictry2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictry)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage2
            // 
            this.btnImage2.Location = new System.Drawing.Point(359, 332);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.Size = new System.Drawing.Size(139, 44);
            this.btnImage2.TabIndex = 0;
            this.btnImage2.Text = "Image From Resource";
            this.btnImage2.UseVisualStyleBackColor = true;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // pictry
            // 
            this.pictry.Location = new System.Drawing.Point(20, 69);
            this.pictry.Name = "pictry";
            this.pictry.Size = new System.Drawing.Size(187, 176);
            this.pictry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictry.TabIndex = 1;
            this.pictry.TabStop = false;
            this.pictry.Click += new System.EventHandler(this.pictry_Click);
            // 
            // btnImage1
            // 
            this.btnImage1.Location = new System.Drawing.Point(173, 329);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.Size = new System.Drawing.Size(126, 47);
            this.btnImage1.TabIndex = 2;
            this.btnImage1.Text = "Image From File";
            this.btnImage1.UseVisualStyleBackColor = true;
            this.btnImage1.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.pictry2);
            this.grpBox.Controls.Add(this.pictry);
            this.grpBox.Location = new System.Drawing.Point(116, 53);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(437, 270);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Picture Box";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(663, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictry2
            // 
            this.pictry2.Location = new System.Drawing.Point(227, 69);
            this.pictry2.Name = "pictry2";
            this.pictry2.Size = new System.Drawing.Size(187, 176);
            this.pictry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictry2.TabIndex = 2;
            this.pictry2.TabStop = false;
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnImage1);
            this.Controls.Add(this.btnImage2);
            this.Name = "frmPicture";
            this.Text = "frmPicture";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            ((System.ComponentModel.ISupportInitialize)(this.pictry)).EndInit();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage2;
        private System.Windows.Forms.PictureBox pictry;
        private System.Windows.Forms.Button btnImage1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictry2;
    }
}