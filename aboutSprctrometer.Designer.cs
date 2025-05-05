namespace WindowsFormsApp1
{
    partial class aboutSprctrometer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutSprctrometer));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.waveLengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.waveLengthLabel);
            this.guna2Panel3.Controls.Add(this.SerialNumberLabel);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel3.Location = new System.Drawing.Point(14, 23);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(357, 218);
            this.guna2Panel3.TabIndex = 1;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SerialNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SerialNumberLabel.Location = new System.Drawing.Point(26, 49);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(130, 18);
            this.SerialNumberLabel.TabIndex = 0;
            this.SerialNumberLabel.Text = "Серийный номер:";
            // 
            // waveLengthLabel
            // 
            this.waveLengthLabel.AutoSize = true;
            this.waveLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.waveLengthLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.waveLengthLabel.Location = new System.Drawing.Point(26, 80);
            this.waveLengthLabel.Name = "waveLengthLabel";
            this.waveLengthLabel.Size = new System.Drawing.Size(98, 18);
            this.waveLengthLabel.TabIndex = 1;
            this.waveLengthLabel.Text = "Длины волн:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель спектрометра: ATP8000";
            // 
            // aboutSprctrometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.guna2Panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(399, 301);
            this.MinimumSize = new System.Drawing.Size(399, 301);
            this.Name = "aboutSprctrometer";
            this.Text = "Информация об устройстве";
            this.Load += new System.EventHandler(this.aboutSprctrometer_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label waveLengthLabel;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label label1;
    }
}