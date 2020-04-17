namespace Naseem_1847585
{
    partial class frmCombo
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
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.btnMethod1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnRemoveIndex = new System.Windows.Forms.Button();
            this.btnRemoveItem2 = new System.Windows.Forms.Button();
            this.btnRemoveItem1 = new System.Windows.Forms.Button();
            this.btnMethod2 = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(174, 151);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 0;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // btnMethod1
            // 
            this.btnMethod1.Location = new System.Drawing.Point(148, 55);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(94, 48);
            this.btnMethod1.TabIndex = 1;
            this.btnMethod1.Text = "Show Selcted Method1";
            this.btnMethod1.UseVisualStyleBackColor = true;
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod1_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(531, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(248, 334);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(84, 43);
            this.btnRemoveName.TabIndex = 3;
            this.btnRemoveName.Text = "Remove By Name";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnRemoveIndex
            // 
            this.btnRemoveIndex.Location = new System.Drawing.Point(148, 334);
            this.btnRemoveIndex.Name = "btnRemoveIndex";
            this.btnRemoveIndex.Size = new System.Drawing.Size(94, 43);
            this.btnRemoveIndex.TabIndex = 4;
            this.btnRemoveIndex.Text = "Remove By Index";
            this.btnRemoveIndex.UseVisualStyleBackColor = true;
            this.btnRemoveIndex.Click += new System.EventHandler(this.btnRemoveIndex_Click);
            // 
            // btnRemoveItem2
            // 
            this.btnRemoveItem2.Location = new System.Drawing.Point(496, 142);
            this.btnRemoveItem2.Name = "btnRemoveItem2";
            this.btnRemoveItem2.Size = new System.Drawing.Size(110, 58);
            this.btnRemoveItem2.TabIndex = 5;
            this.btnRemoveItem2.Text = "Remove 2nd Last Item";
            this.btnRemoveItem2.UseVisualStyleBackColor = true;
            this.btnRemoveItem2.Click += new System.EventHandler(this.btnRemoveItem2_Click);
            // 
            // btnRemoveItem1
            // 
            this.btnRemoveItem1.Location = new System.Drawing.Point(496, 55);
            this.btnRemoveItem1.Name = "btnRemoveItem1";
            this.btnRemoveItem1.Size = new System.Drawing.Size(110, 61);
            this.btnRemoveItem1.TabIndex = 6;
            this.btnRemoveItem1.Text = "Remove Last Item";
            this.btnRemoveItem1.UseVisualStyleBackColor = true;
            this.btnRemoveItem1.Click += new System.EventHandler(this.btnRemoveItem1_Click);
            // 
            // btnMethod2
            // 
            this.btnMethod2.Location = new System.Drawing.Point(248, 55);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(93, 48);
            this.btnMethod2.TabIndex = 7;
            this.btnMethod2.Text = "Show Selcted Method2";
            this.btnMethod2.UseVisualStyleBackColor = true;
            this.btnMethod2.Click += new System.EventHandler(this.btnMethod2_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(127, 154);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Days";
            this.lblDays.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnMethod2);
            this.Controls.Add(this.btnRemoveItem1);
            this.Controls.Add(this.btnRemoveItem2);
            this.Controls.Add(this.btnRemoveIndex);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMethod1);
            this.Controls.Add(this.cmbDays);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button btnMethod1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnRemoveIndex;
        private System.Windows.Forms.Button btnRemoveItem2;
        private System.Windows.Forms.Button btnRemoveItem1;
        private System.Windows.Forms.Button btnMethod2;
        private System.Windows.Forms.Label lblDays;
    }
}