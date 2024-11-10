namespace WindowsFormsApp1
{
    partial class ExtTrigger
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
            this.onExtTrigger = new System.Windows.Forms.CheckBox();
            this.extTrigStopManualButton = new System.Windows.Forms.RadioButton();
            this.extTrigStopAutomaticButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeOffInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onExtTrigger
            // 
            this.onExtTrigger.AutoSize = true;
            this.onExtTrigger.Location = new System.Drawing.Point(151, 44);
            this.onExtTrigger.Name = "onExtTrigger";
            this.onExtTrigger.Size = new System.Drawing.Size(113, 17);
            this.onExtTrigger.TabIndex = 0;
            this.onExtTrigger.Text = "Внешний триггер";
            this.onExtTrigger.UseVisualStyleBackColor = true;
            this.onExtTrigger.CheckedChanged += new System.EventHandler(this.onExtTrigger_CheckedChanged);
            // 
            // extTrigStopManualButton
            // 
            this.extTrigStopManualButton.AutoSize = true;
            this.extTrigStopManualButton.Checked = true;
            this.extTrigStopManualButton.Location = new System.Drawing.Point(151, 91);
            this.extTrigStopManualButton.Name = "extTrigStopManualButton";
            this.extTrigStopManualButton.Size = new System.Drawing.Size(67, 17);
            this.extTrigStopManualButton.TabIndex = 1;
            this.extTrigStopManualButton.TabStop = true;
            this.extTrigStopManualButton.Text = "Вручную";
            this.extTrigStopManualButton.UseVisualStyleBackColor = true;
            this.extTrigStopManualButton.CheckedChanged += new System.EventHandler(this.extTrigStopManualButton_CheckedChanged);
            // 
            // extTrigStopAutomaticButton
            // 
            this.extTrigStopAutomaticButton.AutoSize = true;
            this.extTrigStopAutomaticButton.Location = new System.Drawing.Point(151, 114);
            this.extTrigStopAutomaticButton.Name = "extTrigStopAutomaticButton";
            this.extTrigStopAutomaticButton.Size = new System.Drawing.Size(139, 17);
            this.extTrigStopAutomaticButton.TabIndex = 2;
            this.extTrigStopAutomaticButton.Text = "Автоматически после:";
            this.extTrigStopAutomaticButton.UseVisualStyleBackColor = true;
            this.extTrigStopAutomaticButton.CheckedChanged += new System.EventHandler(this.extTrigStopAutomaticButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Включить внешний \r\nтриггер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Остановка внешнего \r\nтриггера";
            // 
            // timeOffInput
            // 
            this.timeOffInput.Enabled = false;
            this.timeOffInput.Location = new System.Drawing.Point(296, 113);
            this.timeOffInput.Name = "timeOffInput";
            this.timeOffInput.Size = new System.Drawing.Size(57, 20);
            this.timeOffInput.TabIndex = 5;
            this.timeOffInput.Text = "500";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(68, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(242, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "мс";
            // 
            // ExtTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeOffInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extTrigStopAutomaticButton);
            this.Controls.Add(this.extTrigStopManualButton);
            this.Controls.Add(this.onExtTrigger);
            this.MaximumSize = new System.Drawing.Size(418, 254);
            this.MinimumSize = new System.Drawing.Size(418, 254);
            this.Name = "ExtTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внешний триггер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onExtTrigger;
        private System.Windows.Forms.RadioButton extTrigStopManualButton;
        private System.Windows.Forms.RadioButton extTrigStopAutomaticButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeOffInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
    }
}