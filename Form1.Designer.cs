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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearCurveBtn = new System.Windows.Forms.Button();
            this.stopScanBtn = new System.Windows.Forms.Button();
            this.ContinScanBtn = new System.Windows.Forms.Button();
            this.oneScanBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.averageInput = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.findPeakBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.peakWidthInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.thresholdInput = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.saveDarkBtn = new System.Windows.Forms.Button();
            this.saveRefBtn = new System.Windows.Forms.Button();
            this.ProccesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.darkSpectCh = new System.Windows.Forms.CheckBox();
            this.nonlinearCorCh = new System.Windows.Forms.CheckBox();
            this.waveformCorCh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ScanIntervalInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeMicrosInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.irradiance = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSpectralDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудываниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калибровкаДлиныВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОбУстройствеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onSpectrometer = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.насройкаОсиХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пиксельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.длинаВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКривыхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.измеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.временныеРядыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внешнийТриггерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.критическаяТочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearCurveBtn);
            this.panel1.Controls.Add(this.stopScanBtn);
            this.panel1.Controls.Add(this.ContinScanBtn);
            this.panel1.Controls.Add(this.oneScanBtn);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 191);
            this.panel1.TabIndex = 0;
            // 
            // clearCurveBtn
            // 
            this.clearCurveBtn.Location = new System.Drawing.Point(236, 94);
            this.clearCurveBtn.Name = "clearCurveBtn";
            this.clearCurveBtn.Size = new System.Drawing.Size(106, 35);
            this.clearCurveBtn.TabIndex = 3;
            this.clearCurveBtn.Text = "очистить график";
            this.clearCurveBtn.UseVisualStyleBackColor = true;
            this.clearCurveBtn.Click += new System.EventHandler(this.clearCurveBtn_Click);
            // 
            // stopScanBtn
            // 
            this.stopScanBtn.Location = new System.Drawing.Point(236, 39);
            this.stopScanBtn.Name = "stopScanBtn";
            this.stopScanBtn.Size = new System.Drawing.Size(106, 35);
            this.stopScanBtn.TabIndex = 2;
            this.stopScanBtn.Text = "остановить сканирование";
            this.stopScanBtn.UseVisualStyleBackColor = true;
            // 
            // ContinScanBtn
            // 
            this.ContinScanBtn.Location = new System.Drawing.Point(42, 94);
            this.ContinScanBtn.Name = "ContinScanBtn";
            this.ContinScanBtn.Size = new System.Drawing.Size(106, 35);
            this.ContinScanBtn.TabIndex = 1;
            this.ContinScanBtn.Text = "непрерывное сканирование";
            this.ContinScanBtn.UseVisualStyleBackColor = true;
            // 
            // oneScanBtn
            // 
            this.oneScanBtn.Location = new System.Drawing.Point(42, 39);
            this.oneScanBtn.Name = "oneScanBtn";
            this.oneScanBtn.Size = new System.Drawing.Size(106, 35);
            this.oneScanBtn.TabIndex = 0;
            this.oneScanBtn.Text = "однократное сканирование";
            this.oneScanBtn.UseVisualStyleBackColor = true;
            this.oneScanBtn.Click += new System.EventHandler(this.oneScanBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.notificationsLabel);
            this.panel2.Location = new System.Drawing.Point(12, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 88);
            this.panel2.TabIndex = 1;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationsLabel.Location = new System.Drawing.Point(15, 4);
            this.notificationsLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(32, 17);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "111";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 185);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 140);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(12, 516);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 170);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.averageInput);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(417, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(829, 191);
            this.panel6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(543, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Поиск пика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Усред.Скан";
            // 
            // averageInput
            // 
            this.averageInput.Location = new System.Drawing.Point(113, 156);
            this.averageInput.Name = "averageInput";
            this.averageInput.Size = new System.Drawing.Size(48, 20);
            this.averageInput.TabIndex = 6;
            this.averageInput.Text = "1";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.findPeakBtn);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.peakWidthInput);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.thresholdInput);
            this.panel10.Location = new System.Drawing.Point(548, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(266, 135);
            this.panel10.TabIndex = 5;
            // 
            // findPeakBtn
            // 
            this.findPeakBtn.Location = new System.Drawing.Point(193, 41);
            this.findPeakBtn.Name = "findPeakBtn";
            this.findPeakBtn.Size = new System.Drawing.Size(55, 40);
            this.findPeakBtn.TabIndex = 3;
            this.findPeakBtn.Text = "OK";
            this.findPeakBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ширина";
            // 
            // peakWidthInput
            // 
            this.peakWidthInput.Location = new System.Drawing.Point(82, 74);
            this.peakWidthInput.Name = "peakWidthInput";
            this.peakWidthInput.Size = new System.Drawing.Size(68, 20);
            this.peakWidthInput.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Порог";
            // 
            // thresholdInput
            // 
            this.thresholdInput.Location = new System.Drawing.Point(82, 28);
            this.thresholdInput.Name = "thresholdInput";
            this.thresholdInput.Size = new System.Drawing.Size(68, 20);
            this.thresholdInput.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.saveDarkBtn);
            this.panel9.Controls.Add(this.saveRefBtn);
            this.panel9.Controls.Add(this.ProccesCheckedListBox);
            this.panel9.Location = new System.Drawing.Point(361, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(181, 135);
            this.panel9.TabIndex = 4;
            // 
            // saveDarkBtn
            // 
            this.saveDarkBtn.Location = new System.Drawing.Point(3, 71);
            this.saveDarkBtn.Name = "saveDarkBtn";
            this.saveDarkBtn.Size = new System.Drawing.Size(55, 40);
            this.saveDarkBtn.TabIndex = 2;
            this.saveDarkBtn.Text = "Dark";
            this.saveDarkBtn.UseVisualStyleBackColor = true;
            // 
            // saveRefBtn
            // 
            this.saveRefBtn.Location = new System.Drawing.Point(3, 17);
            this.saveRefBtn.Name = "saveRefBtn";
            this.saveRefBtn.Size = new System.Drawing.Size(55, 40);
            this.saveRefBtn.TabIndex = 1;
            this.saveRefBtn.Text = "Ref";
            this.saveRefBtn.UseVisualStyleBackColor = true;
            // 
            // ProccesCheckedListBox
            // 
            this.ProccesCheckedListBox.FormattingEnabled = true;
            this.ProccesCheckedListBox.Items.AddRange(new object[] {
            "Спектр S",
            "Пропускание T",
            "Поглощение А",
            "Отражение R",
            "Освещенность Е"});
            this.ProccesCheckedListBox.Location = new System.Drawing.Point(64, 3);
            this.ProccesCheckedListBox.Name = "ProccesCheckedListBox";
            this.ProccesCheckedListBox.Size = new System.Drawing.Size(112, 124);
            this.ProccesCheckedListBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.darkSpectCh);
            this.panel7.Controls.Add(this.nonlinearCorCh);
            this.panel7.Controls.Add(this.waveformCorCh);
            this.panel7.Location = new System.Drawing.Point(230, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 135);
            this.panel7.TabIndex = 3;
            // 
            // darkSpectCh
            // 
            this.darkSpectCh.AutoSize = true;
            this.darkSpectCh.Location = new System.Drawing.Point(16, 89);
            this.darkSpectCh.Name = "darkSpectCh";
            this.darkSpectCh.Size = new System.Drawing.Size(76, 17);
            this.darkSpectCh.TabIndex = 2;
            this.darkSpectCh.Text = "Выч.Темн";
            this.darkSpectCh.UseVisualStyleBackColor = true;
            // 
            // nonlinearCorCh
            // 
            this.nonlinearCorCh.AutoSize = true;
            this.nonlinearCorCh.Location = new System.Drawing.Point(16, 54);
            this.nonlinearCorCh.Name = "nonlinearCorCh";
            this.nonlinearCorCh.Size = new System.Drawing.Size(88, 17);
            this.nonlinearCorCh.TabIndex = 1;
            this.nonlinearCorCh.Text = "Нелинейная";
            this.nonlinearCorCh.UseVisualStyleBackColor = true;
            // 
            // waveformCorCh
            // 
            this.waveformCorCh.AutoSize = true;
            this.waveformCorCh.Location = new System.Drawing.Point(16, 19);
            this.waveformCorCh.Name = "waveformCorCh";
            this.waveformCorCh.Size = new System.Drawing.Size(101, 17);
            this.waveformCorCh.TabIndex = 0;
            this.waveformCorCh.Text = "Формы Волны";
            this.waveformCorCh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Коррекция измерения";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.ScanIntervalInput);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.filterInput);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.timeMicrosInput);
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(18, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(191, 107);
            this.panel8.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ин.Скан/мс";
            // 
            // ScanIntervalInput
            // 
            this.ScanIntervalInput.Location = new System.Drawing.Point(94, 71);
            this.ScanIntervalInput.Name = "ScanIntervalInput";
            this.ScanIntervalInput.Size = new System.Drawing.Size(48, 20);
            this.ScanIntervalInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фильтр";
            // 
            // filterInput
            // 
            this.filterInput.FormattingEnabled = true;
            this.filterInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.filterInput.Location = new System.Drawing.Point(94, 44);
            this.filterInput.Name = "filterInput";
            this.filterInput.Size = new System.Drawing.Size(48, 21);
            this.filterInput.TabIndex = 2;
            this.filterInput.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вр.скан/мс";
            // 
            // timeMicrosInput
            // 
            this.timeMicrosInput.Location = new System.Drawing.Point(94, 17);
            this.timeMicrosInput.Name = "timeMicrosInput";
            this.timeMicrosInput.Size = new System.Drawing.Size(48, 20);
            this.timeMicrosInput.TabIndex = 0;
            this.timeMicrosInput.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.irradiance);
            this.tabControl1.Location = new System.Drawing.Point(922, 232);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 458);
            this.tabControl1.TabIndex = 5;
            // 
            // irradiance
            // 
            this.irradiance.Location = new System.Drawing.Point(4, 22);
            this.irradiance.Name = "irradiance";
            this.irradiance.Padding = new System.Windows.Forms.Padding(3);
            this.irradiance.Size = new System.Drawing.Size(316, 432);
            this.irradiance.TabIndex = 0;
            this.irradiance.Text = "Освещенность";
            this.irradiance.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.оборудываниеToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.измеренияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSpectralDataMenuItem,
            this.manualSaveDataToolStripMenuItem,
            this.автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Файлы";
            // 
            // loadSpectralDataMenuItem
            // 
            this.loadSpectralDataMenuItem.Name = "loadSpectralDataMenuItem";
            this.loadSpectralDataMenuItem.Size = new System.Drawing.Size(358, 22);
            this.loadSpectralDataMenuItem.Text = "Загрузить спектральные данные";
            this.loadSpectralDataMenuItem.Click += new System.EventHandler(this.loadSpectralDataMenuItem_Click);
            // 
            // manualSaveDataToolStripMenuItem
            // 
            this.manualSaveDataToolStripMenuItem.Name = "manualSaveDataToolStripMenuItem";
            this.manualSaveDataToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.manualSaveDataToolStripMenuItem.Text = "Ручное сохранение спектральных данных";
            this.manualSaveDataToolStripMenuItem.Click += new System.EventHandler(this.manualSaveDataToolStripMenuItem_Click);
            // 
            // автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem
            // 
            this.автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem.Name = "автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem";
            this.автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem.Text = "Автоматическое сохранение спектральных данных";
            // 
            // оборудываниеToolStripMenuItem
            // 
            this.оборудываниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калибровкаДлиныВолныToolStripMenuItem,
            this.другоеToolStripMenuItem,
            this.информацияОбУстройствеToolStripMenuItem,
            this.onSpectrometer});
            this.оборудываниеToolStripMenuItem.Name = "оборудываниеToolStripMenuItem";
            this.оборудываниеToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.оборудываниеToolStripMenuItem.Text = "Оборудование";
            // 
            // калибровкаДлиныВолныToolStripMenuItem
            // 
            this.калибровкаДлиныВолныToolStripMenuItem.Name = "калибровкаДлиныВолныToolStripMenuItem";
            this.калибровкаДлиныВолныToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.калибровкаДлиныВолныToolStripMenuItem.Text = "Калибровка длины волны";
            // 
            // другоеToolStripMenuItem
            // 
            this.другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            this.другоеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.другоеToolStripMenuItem.Text = "Другое";
            // 
            // информацияОбУстройствеToolStripMenuItem
            // 
            this.информацияОбУстройствеToolStripMenuItem.Name = "информацияОбУстройствеToolStripMenuItem";
            this.информацияОбУстройствеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.информацияОбУстройствеToolStripMenuItem.Text = "Информация об устройстве";
            // 
            // onSpectrometer
            // 
            this.onSpectrometer.Name = "onSpectrometer";
            this.onSpectrometer.Size = new System.Drawing.Size(229, 22);
            this.onSpectrometer.Text = "Подключить спектрометр";
            this.onSpectrometer.Click += new System.EventHandler(this.onSpectrometer_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.насройкаОсиХToolStripMenuItem,
            this.количествоКривыхToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // насройкаОсиХToolStripMenuItem
            // 
            this.насройкаОсиХToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пиксельToolStripMenuItem,
            this.длинаВолныToolStripMenuItem,
            this.времяToolStripMenuItem});
            this.насройкаОсиХToolStripMenuItem.Name = "насройкаОсиХToolStripMenuItem";
            this.насройкаОсиХToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.насройкаОсиХToolStripMenuItem.Text = "Насройка оси Х";
            // 
            // пиксельToolStripMenuItem
            // 
            this.пиксельToolStripMenuItem.Name = "пиксельToolStripMenuItem";
            this.пиксельToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пиксельToolStripMenuItem.Text = "Пиксель";
            // 
            // длинаВолныToolStripMenuItem
            // 
            this.длинаВолныToolStripMenuItem.Name = "длинаВолныToolStripMenuItem";
            this.длинаВолныToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.длинаВолныToolStripMenuItem.Text = "Длина волны";
            // 
            // времяToolStripMenuItem
            // 
            this.времяToolStripMenuItem.Name = "времяToolStripMenuItem";
            this.времяToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.времяToolStripMenuItem.Text = "Время";
            // 
            // количествоКривыхToolStripMenuItem
            // 
            this.количествоКривыхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.другоеToolStripMenuItem1});
            this.количествоКривыхToolStripMenuItem.Name = "количествоКривыхToolStripMenuItem";
            this.количествоКривыхToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.количествоКривыхToolStripMenuItem.Text = "Количество кривых";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem5.Text = "5";
            // 
            // другоеToolStripMenuItem1
            // 
            this.другоеToolStripMenuItem1.Name = "другоеToolStripMenuItem1";
            this.другоеToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.другоеToolStripMenuItem1.Text = "другое";
            // 
            // измеренияToolStripMenuItem
            // 
            this.измеренияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.временныеРядыToolStripMenuItem,
            this.коррекцияToolStripMenuItem,
            this.внешнийТриггерToolStripMenuItem,
            this.критическаяТочкаToolStripMenuItem});
            this.измеренияToolStripMenuItem.Name = "измеренияToolStripMenuItem";
            this.измеренияToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.измеренияToolStripMenuItem.Text = "Измерение";
            // 
            // временныеРядыToolStripMenuItem
            // 
            this.временныеРядыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.активироватьToolStripMenuItem});
            this.временныеРядыToolStripMenuItem.Name = "временныеРядыToolStripMenuItem";
            this.временныеРядыToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.временныеРядыToolStripMenuItem.Text = "Временные ряды";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.configureToolStripMenuItem.Text = "Configure Acquisition";
            // 
            // активироватьToolStripMenuItem
            // 
            this.активироватьToolStripMenuItem.Name = "активироватьToolStripMenuItem";
            this.активироватьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.активироватьToolStripMenuItem.Text = "Активировать";
            // 
            // коррекцияToolStripMenuItem
            // 
            this.коррекцияToolStripMenuItem.Name = "коррекцияToolStripMenuItem";
            this.коррекцияToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.коррекцияToolStripMenuItem.Text = "Коррекция освещенности";
            // 
            // внешнийТриггерToolStripMenuItem
            // 
            this.внешнийТриггерToolStripMenuItem.Name = "внешнийТриггерToolStripMenuItem";
            this.внешнийТриггерToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.внешнийТриггерToolStripMenuItem.Text = "Внешний триггер";
            // 
            // критическаяТочкаToolStripMenuItem
            // 
            this.критическаяТочкаToolStripMenuItem.Name = "критическаяТочкаToolStripMenuItem";
            this.критическаяТочкаToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.критическаяТочкаToolStripMenuItem.Text = "Критическая точка";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(665, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Загрузка данных спектра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 691);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1274, 730);
            this.Name = "Form1";
            this.Text = "SpectrometerApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button oneScanBtn;
        private System.Windows.Forms.Button clearCurveBtn;
        private System.Windows.Forms.Button stopScanBtn;
        private System.Windows.Forms.Button ContinScanBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage irradiance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeMicrosInput;
        private System.Windows.Forms.CheckedListBox ProccesCheckedListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox averageInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ScanIntervalInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterInput;
        private System.Windows.Forms.CheckBox darkSpectCh;
        private System.Windows.Forms.CheckBox nonlinearCorCh;
        private System.Windows.Forms.CheckBox waveformCorCh;
        private System.Windows.Forms.Button saveDarkBtn;
        private System.Windows.Forms.Button saveRefBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findPeakBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox peakWidthInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox thresholdInput;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadSpectralDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSaveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическоеСохранениеСпектральныхДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудываниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калибровкаДлиныВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОбУстройствеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem насройкаОсиХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоКривыхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem измеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem временныеРядыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внешнийТриггерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem критическаяТочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пиксельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem длинаВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem другоеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSpectrometer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
    }
}

