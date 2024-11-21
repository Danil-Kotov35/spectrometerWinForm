namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.oneScanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.findPeakBtn = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.parametersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.quantityPeakInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.thresholdInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.averageInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.ScanIntervalInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.filterInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeMicrosInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.stopScanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ContinScanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.clearCurveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pixelXToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.axesWaveLenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.parameterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.parameterQuit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.saveDarkMode = new Guna.UI2.WinForms.Guna2Button();
            this.loadDarkModeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.darkModeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.quantityLines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.extTriggerMenuItem = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.onSpectrometer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.darkSpectCh = new Guna.UI2.WinForms.Guna2CheckBox();
            this.waveformCorCh = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nonlinearCorCh = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.automaticSaveToolStripMenuItem = new Guna.UI2.WinForms.Guna2CheckBox();
            this.saveToPNGMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.manualSaveDataToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.loadSpectralDataMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.closeSpectrometerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.parameterPanel.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.notificationsLabel.Location = new System.Drawing.Point(3, 489);
            this.notificationsLabel.MaximumSize = new System.Drawing.Size(260, 0);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(32, 17);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "111";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(27, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Усред.Скан";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ин.Скан/мс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фильтр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вр.скан/мс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(27, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(27, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Порог";
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Red;
            this.StatusPanel.Location = new System.Drawing.Point(242, 507);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(13, 13);
            this.StatusPanel.TabIndex = 8;
            // 
            // oneScanBtn
            // 
            this.oneScanBtn.BackColor = System.Drawing.Color.Transparent;
            this.oneScanBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.oneScanBtn.BorderRadius = 10;
            this.oneScanBtn.BorderThickness = 1;
            this.oneScanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.oneScanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.oneScanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.oneScanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.oneScanBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.oneScanBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.oneScanBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.oneScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.oneScanBtn.Location = new System.Drawing.Point(12, 11);
            this.oneScanBtn.Name = "oneScanBtn";
            this.oneScanBtn.Size = new System.Drawing.Size(243, 42);
            this.oneScanBtn.TabIndex = 9;
            this.oneScanBtn.Text = "Одиночное сканирование";
            this.oneScanBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.oneScanBtn.UseTransparentBackground = true;
            this.oneScanBtn.Click += new System.EventHandler(this.oneScanBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.Controls.Add(this.findPeakBtn);
            this.guna2Panel1.Controls.Add(this.progressBar1);
            this.guna2Panel1.Controls.Add(this.parametersBtn);
            this.guna2Panel1.Controls.Add(this.quantityPeakInput);
            this.guna2Panel1.Controls.Add(this.thresholdInput);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.averageInput);
            this.guna2Panel1.Controls.Add(this.StatusPanel);
            this.guna2Panel1.Controls.Add(this.ScanIntervalInput);
            this.guna2Panel1.Controls.Add(this.filterInput);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.timeMicrosInput);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.notificationsLabel);
            this.guna2Panel1.Controls.Add(this.stopScanBtn);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.ContinScanBtn);
            this.guna2Panel1.Controls.Add(this.oneScanBtn);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(268, 556);
            this.guna2Panel1.TabIndex = 9;
            // 
            // findPeakBtn
            // 
            this.findPeakBtn.BackColor = System.Drawing.Color.Transparent;
            this.findPeakBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.findPeakBtn.BorderRadius = 10;
            this.findPeakBtn.BorderThickness = 1;
            this.findPeakBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.findPeakBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.findPeakBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.findPeakBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.findPeakBtn.FillColor = System.Drawing.Color.Transparent;
            this.findPeakBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.findPeakBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.findPeakBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.findPeakBtn.Location = new System.Drawing.Point(183, 363);
            this.findPeakBtn.Name = "findPeakBtn";
            this.findPeakBtn.Size = new System.Drawing.Size(55, 47);
            this.findPeakBtn.TabIndex = 22;
            this.findPeakBtn.Text = "ОК";
            this.findPeakBtn.UseTransparentBackground = true;
            this.findPeakBtn.Click += new System.EventHandler(this.findPeakBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 541);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.progressBar1.Size = new System.Drawing.Size(268, 12);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Text = "guna2ProgressBar1";
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // parametersBtn
            // 
            this.parametersBtn.BackColor = System.Drawing.Color.Transparent;
            this.parametersBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.parametersBtn.BorderRadius = 10;
            this.parametersBtn.BorderThickness = 1;
            this.parametersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.parametersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.parametersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.parametersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.parametersBtn.FillColor = System.Drawing.Color.Transparent;
            this.parametersBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.parametersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.parametersBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.parametersBtn.Location = new System.Drawing.Point(12, 428);
            this.parametersBtn.Name = "parametersBtn";
            this.parametersBtn.Size = new System.Drawing.Size(243, 42);
            this.parametersBtn.TabIndex = 21;
            this.parametersBtn.Text = "Параметры";
            this.parametersBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.parametersBtn.UseTransparentBackground = true;
            this.parametersBtn.Click += new System.EventHandler(this.parametersBtn_Click);
            // 
            // quantityPeakInput
            // 
            this.quantityPeakInput.BackColor = System.Drawing.Color.Transparent;
            this.quantityPeakInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.quantityPeakInput.BorderRadius = 6;
            this.quantityPeakInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityPeakInput.DefaultText = "5";
            this.quantityPeakInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityPeakInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityPeakInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityPeakInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityPeakInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.quantityPeakInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityPeakInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityPeakInput.ForeColor = System.Drawing.Color.White;
            this.quantityPeakInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityPeakInput.Location = new System.Drawing.Point(107, 391);
            this.quantityPeakInput.Name = "quantityPeakInput";
            this.quantityPeakInput.PasswordChar = '\0';
            this.quantityPeakInput.PlaceholderText = "";
            this.quantityPeakInput.SelectedText = "";
            this.quantityPeakInput.Size = new System.Drawing.Size(49, 20);
            this.quantityPeakInput.TabIndex = 20;
            // 
            // thresholdInput
            // 
            this.thresholdInput.BackColor = System.Drawing.Color.Transparent;
            this.thresholdInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.thresholdInput.BorderRadius = 6;
            this.thresholdInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thresholdInput.DefaultText = "1000";
            this.thresholdInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thresholdInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thresholdInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thresholdInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thresholdInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.thresholdInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thresholdInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thresholdInput.ForeColor = System.Drawing.Color.White;
            this.thresholdInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thresholdInput.Location = new System.Drawing.Point(107, 363);
            this.thresholdInput.Name = "thresholdInput";
            this.thresholdInput.PasswordChar = '\0';
            this.thresholdInput.PlaceholderText = "";
            this.thresholdInput.SelectedText = "";
            this.thresholdInput.Size = new System.Drawing.Size(49, 20);
            this.thresholdInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Поиск пиков";
            // 
            // averageInput
            // 
            this.averageInput.BackColor = System.Drawing.Color.Transparent;
            this.averageInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.averageInput.BorderRadius = 6;
            this.averageInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.averageInput.DefaultText = "1";
            this.averageInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.averageInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.averageInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.averageInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.averageInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.averageInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.averageInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.averageInput.ForeColor = System.Drawing.Color.White;
            this.averageInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.averageInput.Location = new System.Drawing.Point(107, 281);
            this.averageInput.Name = "averageInput";
            this.averageInput.PasswordChar = '\0';
            this.averageInput.PlaceholderText = "";
            this.averageInput.SelectedText = "";
            this.averageInput.Size = new System.Drawing.Size(49, 20);
            this.averageInput.TabIndex = 17;
            // 
            // ScanIntervalInput
            // 
            this.ScanIntervalInput.BackColor = System.Drawing.Color.Transparent;
            this.ScanIntervalInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.ScanIntervalInput.BorderRadius = 6;
            this.ScanIntervalInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScanIntervalInput.DefaultText = "";
            this.ScanIntervalInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ScanIntervalInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ScanIntervalInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScanIntervalInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScanIntervalInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ScanIntervalInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScanIntervalInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScanIntervalInput.ForeColor = System.Drawing.Color.White;
            this.ScanIntervalInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScanIntervalInput.Location = new System.Drawing.Point(107, 252);
            this.ScanIntervalInput.Name = "ScanIntervalInput";
            this.ScanIntervalInput.PasswordChar = '\0';
            this.ScanIntervalInput.PlaceholderText = "";
            this.ScanIntervalInput.SelectedText = "";
            this.ScanIntervalInput.Size = new System.Drawing.Size(49, 20);
            this.ScanIntervalInput.TabIndex = 16;
            // 
            // filterInput
            // 
            this.filterInput.BackColor = System.Drawing.Color.Transparent;
            this.filterInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.filterInput.BorderRadius = 6;
            this.filterInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterInput.DefaultText = "0";
            this.filterInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.filterInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterInput.ForeColor = System.Drawing.Color.White;
            this.filterInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterInput.Location = new System.Drawing.Point(107, 226);
            this.filterInput.Name = "filterInput";
            this.filterInput.PasswordChar = '\0';
            this.filterInput.PlaceholderText = "";
            this.filterInput.SelectedText = "";
            this.filterInput.Size = new System.Drawing.Size(49, 20);
            this.filterInput.TabIndex = 15;
            // 
            // timeMicrosInput
            // 
            this.timeMicrosInput.BackColor = System.Drawing.Color.Transparent;
            this.timeMicrosInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.timeMicrosInput.BorderRadius = 6;
            this.timeMicrosInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeMicrosInput.DefaultText = "1000";
            this.timeMicrosInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeMicrosInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeMicrosInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeMicrosInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeMicrosInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.timeMicrosInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeMicrosInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeMicrosInput.ForeColor = System.Drawing.Color.White;
            this.timeMicrosInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeMicrosInput.Location = new System.Drawing.Point(107, 200);
            this.timeMicrosInput.Name = "timeMicrosInput";
            this.timeMicrosInput.PasswordChar = '\0';
            this.timeMicrosInput.PlaceholderText = "";
            this.timeMicrosInput.SelectedText = "";
            this.timeMicrosInput.Size = new System.Drawing.Size(49, 20);
            this.timeMicrosInput.TabIndex = 14;
            // 
            // stopScanBtn
            // 
            this.stopScanBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopScanBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.stopScanBtn.BorderRadius = 10;
            this.stopScanBtn.BorderThickness = 1;
            this.stopScanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stopScanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stopScanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.stopScanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stopScanBtn.FillColor = System.Drawing.Color.Transparent;
            this.stopScanBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopScanBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.stopScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.stopScanBtn.Location = new System.Drawing.Point(12, 107);
            this.stopScanBtn.Name = "stopScanBtn";
            this.stopScanBtn.Size = new System.Drawing.Size(243, 42);
            this.stopScanBtn.TabIndex = 12;
            this.stopScanBtn.Text = "Остановить сканирование";
            this.stopScanBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stopScanBtn.UseTransparentBackground = true;
            this.stopScanBtn.Click += new System.EventHandler(this.stopScanBtn_Click);
            // 
            // ContinScanBtn
            // 
            this.ContinScanBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContinScanBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.ContinScanBtn.BorderRadius = 10;
            this.ContinScanBtn.BorderThickness = 1;
            this.ContinScanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ContinScanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ContinScanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ContinScanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ContinScanBtn.FillColor = System.Drawing.Color.Transparent;
            this.ContinScanBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContinScanBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ContinScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.ContinScanBtn.Location = new System.Drawing.Point(12, 59);
            this.ContinScanBtn.Name = "ContinScanBtn";
            this.ContinScanBtn.Size = new System.Drawing.Size(243, 42);
            this.ContinScanBtn.TabIndex = 11;
            this.ContinScanBtn.Text = "Непрерываное сканирование";
            this.ContinScanBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ContinScanBtn.UseTransparentBackground = true;
            this.ContinScanBtn.Click += new System.EventHandler(this.ContinScanBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(306, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(890, 530);
            this.guna2Panel2.TabIndex = 10;
            // 
            // clearCurveBtn
            // 
            this.clearCurveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCurveBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearCurveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.clearCurveBtn.BorderRadius = 10;
            this.clearCurveBtn.BorderThickness = 1;
            this.clearCurveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearCurveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearCurveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearCurveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearCurveBtn.FillColor = System.Drawing.Color.Transparent;
            this.clearCurveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearCurveBtn.ForeColor = System.Drawing.Color.White;
            this.clearCurveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.clearCurveBtn.Location = new System.Drawing.Point(1062, 12);
            this.clearCurveBtn.Name = "clearCurveBtn";
            this.clearCurveBtn.Size = new System.Drawing.Size(122, 30);
            this.clearCurveBtn.TabIndex = 13;
            this.clearCurveBtn.Text = "Очистить график";
            this.clearCurveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clearCurveBtn.Click += new System.EventHandler(this.clearCurveBtn_Click);
            // 
            // pixelXToolStripMenuItem
            // 
            this.pixelXToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.pixelXToolStripMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.pixelXToolStripMenuItem.BorderRadius = 10;
            this.pixelXToolStripMenuItem.BorderThickness = 1;
            this.pixelXToolStripMenuItem.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.pixelXToolStripMenuItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.pixelXToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pixelXToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pixelXToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pixelXToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pixelXToolStripMenuItem.FillColor = System.Drawing.Color.Transparent;
            this.pixelXToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pixelXToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pixelXToolStripMenuItem.Location = new System.Drawing.Point(409, 12);
            this.pixelXToolStripMenuItem.Name = "pixelXToolStripMenuItem";
            this.pixelXToolStripMenuItem.Size = new System.Drawing.Size(105, 30);
            this.pixelXToolStripMenuItem.TabIndex = 15;
            this.pixelXToolStripMenuItem.Text = "Пиксели";
            this.pixelXToolStripMenuItem.Click += new System.EventHandler(this.pixelXToolStripMenuItem_Click);
            // 
            // axesWaveLenBtn
            // 
            this.axesWaveLenBtn.BackColor = System.Drawing.Color.Transparent;
            this.axesWaveLenBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.axesWaveLenBtn.BorderRadius = 10;
            this.axesWaveLenBtn.BorderThickness = 1;
            this.axesWaveLenBtn.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.axesWaveLenBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.axesWaveLenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.axesWaveLenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.axesWaveLenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.axesWaveLenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.axesWaveLenBtn.FillColor = System.Drawing.Color.Transparent;
            this.axesWaveLenBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.axesWaveLenBtn.ForeColor = System.Drawing.Color.White;
            this.axesWaveLenBtn.Location = new System.Drawing.Point(289, 12);
            this.axesWaveLenBtn.Name = "axesWaveLenBtn";
            this.axesWaveLenBtn.Size = new System.Drawing.Size(114, 30);
            this.axesWaveLenBtn.TabIndex = 16;
            this.axesWaveLenBtn.Text = "Длина волны";
            this.axesWaveLenBtn.Click += new System.EventHandler(this.waveLengthToolStripMenuItem_Click);
            // 
            // parameterPanel
            // 
            this.parameterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameterPanel.Controls.Add(this.parameterQuit);
            this.parameterPanel.Controls.Add(this.guna2Panel6);
            this.parameterPanel.Controls.Add(this.guna2Panel5);
            this.parameterPanel.Controls.Add(this.guna2Panel4);
            this.parameterPanel.Controls.Add(this.guna2Panel3);
            this.parameterPanel.Location = new System.Drawing.Point(266, 0);
            this.parameterPanel.Name = "parameterPanel";
            this.parameterPanel.Size = new System.Drawing.Size(930, 558);
            this.parameterPanel.TabIndex = 17;
            this.parameterPanel.Visible = false;
            // 
            // parameterQuit
            // 
            this.parameterQuit.BackColor = System.Drawing.Color.Transparent;
            this.parameterQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.parameterQuit.BorderRadius = 10;
            this.parameterQuit.BorderThickness = 1;
            this.parameterQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.parameterQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.parameterQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.parameterQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.parameterQuit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.parameterQuit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.parameterQuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.parameterQuit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.parameterQuit.Location = new System.Drawing.Point(8, 27);
            this.parameterQuit.Name = "parameterQuit";
            this.parameterQuit.Size = new System.Drawing.Size(119, 53);
            this.parameterQuit.TabIndex = 28;
            this.parameterQuit.Text = "Вернутся к графику";
            this.parameterQuit.UseTransparentBackground = true;
            this.parameterQuit.Click += new System.EventHandler(this.parameterQuit_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.guna2Panel6.BorderRadius = 25;
            this.guna2Panel6.Controls.Add(this.saveDarkMode);
            this.guna2Panel6.Controls.Add(this.loadDarkModeBtn);
            this.guna2Panel6.Controls.Add(this.darkModeBtn);
            this.guna2Panel6.Controls.Add(this.label14);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel6.Location = new System.Drawing.Point(510, 313);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(316, 207);
            this.guna2Panel6.TabIndex = 28;
            // 
            // saveDarkMode
            // 
            this.saveDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.saveDarkMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.saveDarkMode.BorderRadius = 10;
            this.saveDarkMode.BorderThickness = 1;
            this.saveDarkMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveDarkMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveDarkMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.saveDarkMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveDarkMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.saveDarkMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveDarkMode.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveDarkMode.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.saveDarkMode.Location = new System.Drawing.Point(32, 147);
            this.saveDarkMode.Name = "saveDarkMode";
            this.saveDarkMode.Size = new System.Drawing.Size(243, 42);
            this.saveDarkMode.TabIndex = 25;
            this.saveDarkMode.Text = "Сохранить темный спектр";
            this.saveDarkMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveDarkMode.UseTransparentBackground = true;
            this.saveDarkMode.Click += new System.EventHandler(this.saveDarkMode_Click);
            // 
            // loadDarkModeBtn
            // 
            this.loadDarkModeBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadDarkModeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.loadDarkModeBtn.BorderRadius = 10;
            this.loadDarkModeBtn.BorderThickness = 1;
            this.loadDarkModeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadDarkModeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadDarkModeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.loadDarkModeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadDarkModeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.loadDarkModeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadDarkModeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.loadDarkModeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.loadDarkModeBtn.Location = new System.Drawing.Point(32, 99);
            this.loadDarkModeBtn.Name = "loadDarkModeBtn";
            this.loadDarkModeBtn.Size = new System.Drawing.Size(243, 42);
            this.loadDarkModeBtn.TabIndex = 24;
            this.loadDarkModeBtn.Text = "Загрузить темный спектр";
            this.loadDarkModeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loadDarkModeBtn.UseTransparentBackground = true;
            this.loadDarkModeBtn.Click += new System.EventHandler(this.loadDarkModeBtn_Click);
            // 
            // darkModeBtn
            // 
            this.darkModeBtn.BackColor = System.Drawing.Color.Transparent;
            this.darkModeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.darkModeBtn.BorderRadius = 10;
            this.darkModeBtn.BorderThickness = 1;
            this.darkModeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.darkModeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.darkModeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.darkModeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.darkModeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.darkModeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.darkModeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.darkModeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkModeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.darkModeBtn.Location = new System.Drawing.Point(32, 51);
            this.darkModeBtn.Name = "darkModeBtn";
            this.darkModeBtn.Size = new System.Drawing.Size(243, 42);
            this.darkModeBtn.TabIndex = 23;
            this.darkModeBtn.Text = "Включить режим";
            this.darkModeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkModeBtn.UseTransparentBackground = true;
            this.darkModeBtn.Click += new System.EventHandler(this.darkModeBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(27, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Темный спектр";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.guna2Panel5.BorderRadius = 25;
            this.guna2Panel5.Controls.Add(this.closeSpectrometerBtn);
            this.guna2Panel5.Controls.Add(this.quantityLines);
            this.guna2Panel5.Controls.Add(this.label15);
            this.guna2Panel5.Controls.Add(this.temperatureLabel);
            this.guna2Panel5.Controls.Add(this.label13);
            this.guna2Panel5.Controls.Add(this.extTriggerMenuItem);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.Controls.Add(this.onSpectrometer);
            this.guna2Panel5.Controls.Add(this.guna2Button5);
            this.guna2Panel5.Controls.Add(this.label11);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel5.Location = new System.Drawing.Point(510, 27);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(316, 248);
            this.guna2Panel5.TabIndex = 28;
            // 
            // quantityLines
            // 
            this.quantityLines.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.quantityLines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.quantityLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantityLines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.quantityLines.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityLines.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityLines.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quantityLines.ForeColor = System.Drawing.Color.Gainsboro;
            this.quantityLines.ItemHeight = 30;
            this.quantityLines.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.quantityLines.Location = new System.Drawing.Point(199, 185);
            this.quantityLines.Name = "quantityLines";
            this.quantityLines.Size = new System.Drawing.Size(57, 36);
            this.quantityLines.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(299, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "°C";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.temperatureLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.temperatureLabel.Location = new System.Drawing.Point(251, 263);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(19, 20);
            this.temperatureLabel.TabIndex = 32;
            this.temperatureLabel.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(28, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Температура спектрометра: ";
            // 
            // extTriggerMenuItem
            // 
            this.extTriggerMenuItem.AutoSize = true;
            this.extTriggerMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.extTriggerMenuItem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.extTriggerMenuItem.CheckedState.BorderRadius = 0;
            this.extTriggerMenuItem.CheckedState.BorderThickness = 0;
            this.extTriggerMenuItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.extTriggerMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.extTriggerMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.extTriggerMenuItem.Location = new System.Drawing.Point(32, 218);
            this.extTriggerMenuItem.Name = "extTriggerMenuItem";
            this.extTriggerMenuItem.Size = new System.Drawing.Size(160, 24);
            this.extTriggerMenuItem.TabIndex = 27;
            this.extTriggerMenuItem.Text = "Внешний триггер";
            this.extTriggerMenuItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.extTriggerMenuItem.UncheckedState.BorderRadius = 0;
            this.extTriggerMenuItem.UncheckedState.BorderThickness = 0;
            this.extTriggerMenuItem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.extTriggerMenuItem.UseVisualStyleBackColor = false;
            this.extTriggerMenuItem.Click += new System.EventHandler(this.extTriggerMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(28, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Количество кривых";
            // 
            // onSpectrometer
            // 
            this.onSpectrometer.BackColor = System.Drawing.Color.Transparent;
            this.onSpectrometer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.onSpectrometer.BorderRadius = 10;
            this.onSpectrometer.BorderThickness = 1;
            this.onSpectrometer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.onSpectrometer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.onSpectrometer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.onSpectrometer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.onSpectrometer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.onSpectrometer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.onSpectrometer.ForeColor = System.Drawing.Color.Gainsboro;
            this.onSpectrometer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.onSpectrometer.Location = new System.Drawing.Point(32, 88);
            this.onSpectrometer.Name = "onSpectrometer";
            this.onSpectrometer.Size = new System.Drawing.Size(272, 37);
            this.onSpectrometer.TabIndex = 28;
            this.onSpectrometer.Text = "Подключить спектрометр";
            this.onSpectrometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.onSpectrometer.UseTransparentBackground = true;
            this.onSpectrometer.Click += new System.EventHandler(this.onSpectrometer_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.guna2Button5.Location = new System.Drawing.Point(32, 45);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(272, 37);
            this.guna2Button5.TabIndex = 27;
            this.guna2Button5.Text = "Информация об устройстве";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.UseTransparentBackground = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(27, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Настройка спектрометра";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.guna2Panel4.BorderRadius = 25;
            this.guna2Panel4.Controls.Add(this.darkSpectCh);
            this.guna2Panel4.Controls.Add(this.waveformCorCh);
            this.guna2Panel4.Controls.Add(this.nonlinearCorCh);
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel4.Location = new System.Drawing.Point(145, 313);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(316, 207);
            this.guna2Panel4.TabIndex = 27;
            // 
            // darkSpectCh
            // 
            this.darkSpectCh.AutoSize = true;
            this.darkSpectCh.BackColor = System.Drawing.Color.Transparent;
            this.darkSpectCh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkSpectCh.CheckedState.BorderRadius = 0;
            this.darkSpectCh.CheckedState.BorderThickness = 0;
            this.darkSpectCh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkSpectCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.darkSpectCh.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkSpectCh.Location = new System.Drawing.Point(32, 156);
            this.darkSpectCh.Name = "darkSpectCh";
            this.darkSpectCh.Size = new System.Drawing.Size(212, 24);
            this.darkSpectCh.TabIndex = 26;
            this.darkSpectCh.Text = "Вычесть темный спектр";
            this.darkSpectCh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkSpectCh.UncheckedState.BorderRadius = 0;
            this.darkSpectCh.UncheckedState.BorderThickness = 0;
            this.darkSpectCh.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkSpectCh.UseVisualStyleBackColor = false;
            this.darkSpectCh.CheckedChanged += new System.EventHandler(this.darkSpectCh_CheckedChanged);
            // 
            // waveformCorCh
            // 
            this.waveformCorCh.AutoSize = true;
            this.waveformCorCh.BackColor = System.Drawing.Color.Transparent;
            this.waveformCorCh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.waveformCorCh.CheckedState.BorderRadius = 0;
            this.waveformCorCh.CheckedState.BorderThickness = 0;
            this.waveformCorCh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.waveformCorCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.waveformCorCh.ForeColor = System.Drawing.Color.Gainsboro;
            this.waveformCorCh.Location = new System.Drawing.Point(32, 112);
            this.waveformCorCh.Name = "waveformCorCh";
            this.waveformCorCh.Size = new System.Drawing.Size(135, 24);
            this.waveformCorCh.TabIndex = 25;
            this.waveformCorCh.Text = "Формы волны";
            this.waveformCorCh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.waveformCorCh.UncheckedState.BorderRadius = 0;
            this.waveformCorCh.UncheckedState.BorderThickness = 0;
            this.waveformCorCh.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.waveformCorCh.UseVisualStyleBackColor = false;
            this.waveformCorCh.CheckedChanged += new System.EventHandler(this.waveformCorCh_CheckedChanged);
            // 
            // nonlinearCorCh
            // 
            this.nonlinearCorCh.AutoSize = true;
            this.nonlinearCorCh.BackColor = System.Drawing.Color.Transparent;
            this.nonlinearCorCh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonlinearCorCh.CheckedState.BorderRadius = 0;
            this.nonlinearCorCh.CheckedState.BorderThickness = 0;
            this.nonlinearCorCh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonlinearCorCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nonlinearCorCh.ForeColor = System.Drawing.Color.Gainsboro;
            this.nonlinearCorCh.Location = new System.Drawing.Point(32, 69);
            this.nonlinearCorCh.Name = "nonlinearCorCh";
            this.nonlinearCorCh.Size = new System.Drawing.Size(122, 24);
            this.nonlinearCorCh.TabIndex = 24;
            this.nonlinearCorCh.Text = "Нелинейная";
            this.nonlinearCorCh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nonlinearCorCh.UncheckedState.BorderRadius = 0;
            this.nonlinearCorCh.UncheckedState.BorderThickness = 0;
            this.nonlinearCorCh.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nonlinearCorCh.UseVisualStyleBackColor = false;
            this.nonlinearCorCh.CheckedChanged += new System.EventHandler(this.nonlinearCorCh_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(27, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Коррекция измерений";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.Controls.Add(this.automaticSaveToolStripMenuItem);
            this.guna2Panel3.Controls.Add(this.saveToPNGMenuItem);
            this.guna2Panel3.Controls.Add(this.manualSaveDataToolStripMenuItem);
            this.guna2Panel3.Controls.Add(this.loadSpectralDataMenuItem);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.guna2Panel3.Location = new System.Drawing.Point(145, 27);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(316, 248);
            this.guna2Panel3.TabIndex = 0;
            // 
            // automaticSaveToolStripMenuItem
            // 
            this.automaticSaveToolStripMenuItem.AutoSize = true;
            this.automaticSaveToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.automaticSaveToolStripMenuItem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.automaticSaveToolStripMenuItem.CheckedState.BorderRadius = 0;
            this.automaticSaveToolStripMenuItem.CheckedState.BorderThickness = 0;
            this.automaticSaveToolStripMenuItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.automaticSaveToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.automaticSaveToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.automaticSaveToolStripMenuItem.Location = new System.Drawing.Point(32, 177);
            this.automaticSaveToolStripMenuItem.Name = "automaticSaveToolStripMenuItem";
            this.automaticSaveToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.automaticSaveToolStripMenuItem.TabIndex = 27;
            this.automaticSaveToolStripMenuItem.Text = "Автоматическое сохранение ";
            this.automaticSaveToolStripMenuItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.automaticSaveToolStripMenuItem.UncheckedState.BorderRadius = 0;
            this.automaticSaveToolStripMenuItem.UncheckedState.BorderThickness = 0;
            this.automaticSaveToolStripMenuItem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.automaticSaveToolStripMenuItem.UseVisualStyleBackColor = false;
            // 
            // saveToPNGMenuItem
            // 
            this.saveToPNGMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.saveToPNGMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.saveToPNGMenuItem.BorderRadius = 10;
            this.saveToPNGMenuItem.BorderThickness = 1;
            this.saveToPNGMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveToPNGMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveToPNGMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.saveToPNGMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveToPNGMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.saveToPNGMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveToPNGMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveToPNGMenuItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.saveToPNGMenuItem.Location = new System.Drawing.Point(32, 131);
            this.saveToPNGMenuItem.Name = "saveToPNGMenuItem";
            this.saveToPNGMenuItem.Size = new System.Drawing.Size(272, 37);
            this.saveToPNGMenuItem.TabIndex = 26;
            this.saveToPNGMenuItem.Text = "Сохранить график в PNG";
            this.saveToPNGMenuItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveToPNGMenuItem.UseTransparentBackground = true;
            this.saveToPNGMenuItem.Click += new System.EventHandler(this.saveToPNGMenuItem_Click);
            // 
            // manualSaveDataToolStripMenuItem
            // 
            this.manualSaveDataToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.manualSaveDataToolStripMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.manualSaveDataToolStripMenuItem.BorderRadius = 10;
            this.manualSaveDataToolStripMenuItem.BorderThickness = 1;
            this.manualSaveDataToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manualSaveDataToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manualSaveDataToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.manualSaveDataToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manualSaveDataToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.manualSaveDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manualSaveDataToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manualSaveDataToolStripMenuItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.manualSaveDataToolStripMenuItem.Location = new System.Drawing.Point(32, 88);
            this.manualSaveDataToolStripMenuItem.Name = "manualSaveDataToolStripMenuItem";
            this.manualSaveDataToolStripMenuItem.Size = new System.Drawing.Size(272, 37);
            this.manualSaveDataToolStripMenuItem.TabIndex = 24;
            this.manualSaveDataToolStripMenuItem.Text = "Сохранить файл спектра";
            this.manualSaveDataToolStripMenuItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manualSaveDataToolStripMenuItem.UseTransparentBackground = true;
            this.manualSaveDataToolStripMenuItem.Click += new System.EventHandler(this.manualSaveDataToolStripMenuItem_Click);
            // 
            // loadSpectralDataMenuItem
            // 
            this.loadSpectralDataMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.loadSpectralDataMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.loadSpectralDataMenuItem.BorderRadius = 10;
            this.loadSpectralDataMenuItem.BorderThickness = 1;
            this.loadSpectralDataMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadSpectralDataMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadSpectralDataMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.loadSpectralDataMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadSpectralDataMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.loadSpectralDataMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadSpectralDataMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.loadSpectralDataMenuItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.loadSpectralDataMenuItem.Location = new System.Drawing.Point(32, 45);
            this.loadSpectralDataMenuItem.Name = "loadSpectralDataMenuItem";
            this.loadSpectralDataMenuItem.Size = new System.Drawing.Size(272, 37);
            this.loadSpectralDataMenuItem.TabIndex = 23;
            this.loadSpectralDataMenuItem.Text = "Прочитать файл спектра";
            this.loadSpectralDataMenuItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loadSpectralDataMenuItem.UseTransparentBackground = true;
            this.loadSpectralDataMenuItem.Click += new System.EventHandler(this.loadSpectralDataMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(27, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Файлы";
            // 
            // closeSpectrometerBtn
            // 
            this.closeSpectrometerBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeSpectrometerBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.closeSpectrometerBtn.BorderRadius = 10;
            this.closeSpectrometerBtn.BorderThickness = 1;
            this.closeSpectrometerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeSpectrometerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeSpectrometerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.closeSpectrometerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeSpectrometerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.closeSpectrometerBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closeSpectrometerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeSpectrometerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(173)))), ((int)(((byte)(135)))));
            this.closeSpectrometerBtn.Location = new System.Drawing.Point(32, 131);
            this.closeSpectrometerBtn.Name = "closeSpectrometerBtn";
            this.closeSpectrometerBtn.Size = new System.Drawing.Size(272, 37);
            this.closeSpectrometerBtn.TabIndex = 36;
            this.closeSpectrometerBtn.Text = "Отключить спектрометр";
            this.closeSpectrometerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.closeSpectrometerBtn.UseTransparentBackground = true;
            this.closeSpectrometerBtn.Click += new System.EventHandler(this.closeSpectrometerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1196, 555);
            this.Controls.Add(this.parameterPanel);
            this.Controls.Add(this.axesWaveLenBtn);
            this.Controls.Add(this.pixelXToolStripMenuItem);
            this.Controls.Add(this.clearCurveBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1212, 594);
            this.Name = "Form1";
            this.Text = "SpectrometerApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.parameterPanel.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Panel StatusPanel;
        private Guna.UI2.WinForms.Guna2Button oneScanBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button ContinScanBtn;
        private Guna.UI2.WinForms.Guna2Button stopScanBtn;
        private Guna.UI2.WinForms.Guna2Button clearCurveBtn;
        private Guna.UI2.WinForms.Guna2TextBox timeMicrosInput;
        private Guna.UI2.WinForms.Guna2TextBox averageInput;
        private Guna.UI2.WinForms.Guna2TextBox ScanIntervalInput;
        private Guna.UI2.WinForms.Guna2TextBox filterInput;
        private Guna.UI2.WinForms.Guna2TextBox quantityPeakInput;
        private Guna.UI2.WinForms.Guna2TextBox thresholdInput;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button parametersBtn;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2Button findPeakBtn;
        private Guna.UI2.WinForms.Guna2Button pixelXToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button axesWaveLenBtn;
        private Guna.UI2.WinForms.Guna2Panel parameterPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button loadSpectralDataMenuItem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button manualSaveDataToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button saveToPNGMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CheckBox nonlinearCorCh;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CheckBox darkSpectCh;
        private Guna.UI2.WinForms.Guna2CheckBox waveformCorCh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button onSpectrometer;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CheckBox extTriggerMenuItem;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2CheckBox automaticSaveToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox quantityLines;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button darkModeBtn;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button saveDarkMode;
        private Guna.UI2.WinForms.Guna2Button loadDarkModeBtn;
        private Guna.UI2.WinForms.Guna2Button parameterQuit;
        private Guna.UI2.WinForms.Guna2Button closeSpectrometerBtn;
    }
}

