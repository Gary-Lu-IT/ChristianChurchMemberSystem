namespace Form式泛用基督教會會員管理系統.SubForms.Events
{
    partial class FrmEventSettingEditor
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
            BtnCancel = new Button();
            BtnConfirm = new Button();
            label1 = new Label();
            TxtEventName = new TextBox();
            label2 = new Label();
            RdoOnce = new RadioButton();
            RdoYearly = new RadioButton();
            RdoWeekly = new RadioButton();
            RdoMonthly = new RadioButton();
            RdoDaily = new RadioButton();
            tabControl1 = new TabControl();
            TbpOnce = new TabPage();
            DtpHoldTime_Once = new DateTimePicker();
            TbpYearly = new TabPage();
            TpYearly = new DateTimePicker();
            CboDates_Yearly = new ComboBox();
            ChkMonth = new CheckedListBox();
            TbpMonthly = new TabPage();
            TbpWeekly = new TabPage();
            TpWeekly = new DateTimePicker();
            ClbWeekDays = new CheckedListBox();
            TbpDaily = new TabPage();
            TpDaily = new DateTimePicker();
            label3 = new Label();
            TpMonthly = new DateTimePicker();
            CboDates_Monthly = new ComboBox();
            tabControl1.SuspendLayout();
            TbpOnce.SuspendLayout();
            TbpYearly.SuspendLayout();
            TbpMonthly.SuspendLayout();
            TbpWeekly.SuspendLayout();
            TbpDaily.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(518, 328);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 23;
            BtnCancel.Text = "離開";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(418, 328);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 22;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 24;
            label1.Text = "活動/課程名稱";
            // 
            // TxtEventName
            // 
            TxtEventName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtEventName.Location = new Point(176, 12);
            TxtEventName.Name = "TxtEventName";
            TxtEventName.Size = new Size(436, 33);
            TxtEventName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 26;
            label2.Text = "頻率";
            // 
            // RdoOnce
            // 
            RdoOnce.AutoSize = true;
            RdoOnce.Checked = true;
            RdoOnce.Location = new Point(176, 61);
            RdoOnce.Name = "RdoOnce";
            RdoOnce.Size = new Size(93, 29);
            RdoOnce.TabIndex = 27;
            RdoOnce.TabStop = true;
            RdoOnce.Text = "僅一次";
            RdoOnce.UseVisualStyleBackColor = true;
            RdoOnce.CheckedChanged += RdoFrequenciesCheckedChanged;
            // 
            // RdoYearly
            // 
            RdoYearly.AutoSize = true;
            RdoYearly.Location = new Point(275, 61);
            RdoYearly.Name = "RdoYearly";
            RdoYearly.Size = new Size(73, 29);
            RdoYearly.TabIndex = 28;
            RdoYearly.Text = "每年";
            RdoYearly.UseVisualStyleBackColor = true;
            RdoYearly.CheckedChanged += RdoFrequenciesCheckedChanged;
            // 
            // RdoWeekly
            // 
            RdoWeekly.AutoSize = true;
            RdoWeekly.Location = new Point(433, 61);
            RdoWeekly.Name = "RdoWeekly";
            RdoWeekly.Size = new Size(73, 29);
            RdoWeekly.TabIndex = 30;
            RdoWeekly.Text = "每周";
            RdoWeekly.UseVisualStyleBackColor = true;
            RdoWeekly.CheckedChanged += RdoFrequenciesCheckedChanged;
            // 
            // RdoMonthly
            // 
            RdoMonthly.AutoSize = true;
            RdoMonthly.Location = new Point(354, 61);
            RdoMonthly.Name = "RdoMonthly";
            RdoMonthly.Size = new Size(73, 29);
            RdoMonthly.TabIndex = 29;
            RdoMonthly.Text = "每月";
            RdoMonthly.UseVisualStyleBackColor = true;
            RdoMonthly.CheckedChanged += RdoFrequenciesCheckedChanged;
            // 
            // RdoDaily
            // 
            RdoDaily.AutoSize = true;
            RdoDaily.Location = new Point(512, 61);
            RdoDaily.Name = "RdoDaily";
            RdoDaily.Size = new Size(73, 29);
            RdoDaily.TabIndex = 31;
            RdoDaily.Text = "每日";
            RdoDaily.UseVisualStyleBackColor = true;
            RdoDaily.CheckedChanged += RdoFrequenciesCheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(TbpOnce);
            tabControl1.Controls.Add(TbpYearly);
            tabControl1.Controls.Add(TbpMonthly);
            tabControl1.Controls.Add(TbpWeekly);
            tabControl1.Controls.Add(TbpDaily);
            tabControl1.Location = new Point(12, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 226);
            tabControl1.TabIndex = 32;
            // 
            // TbpOnce
            // 
            TbpOnce.Controls.Add(DtpHoldTime_Once);
            TbpOnce.Location = new Point(4, 34);
            TbpOnce.Name = "TbpOnce";
            TbpOnce.Padding = new Padding(3);
            TbpOnce.Size = new Size(592, 188);
            TbpOnce.TabIndex = 0;
            TbpOnce.Text = "僅一次";
            TbpOnce.UseVisualStyleBackColor = true;
            // 
            // DtpHoldTime_Once
            // 
            DtpHoldTime_Once.CustomFormat = "yyyy年M月d日 HH:mm:ss";
            DtpHoldTime_Once.Format = DateTimePickerFormat.Custom;
            DtpHoldTime_Once.Location = new Point(6, 18);
            DtpHoldTime_Once.Name = "DtpHoldTime_Once";
            DtpHoldTime_Once.Size = new Size(560, 33);
            DtpHoldTime_Once.TabIndex = 0;
            // 
            // TbpYearly
            // 
            TbpYearly.Controls.Add(TpYearly);
            TbpYearly.Controls.Add(CboDates_Yearly);
            TbpYearly.Controls.Add(ChkMonth);
            TbpYearly.Location = new Point(4, 34);
            TbpYearly.Name = "TbpYearly";
            TbpYearly.Padding = new Padding(3);
            TbpYearly.Size = new Size(592, 188);
            TbpYearly.TabIndex = 1;
            TbpYearly.Text = "每年";
            TbpYearly.UseVisualStyleBackColor = true;
            // 
            // TpYearly
            // 
            TpYearly.Format = DateTimePickerFormat.Time;
            TpYearly.Location = new Point(163, 128);
            TpYearly.Name = "TpYearly";
            TpYearly.Size = new Size(250, 33);
            TpYearly.TabIndex = 2;
            // 
            // CboDates_Yearly
            // 
            CboDates_Yearly.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDates_Yearly.FormattingEnabled = true;
            CboDates_Yearly.Items.AddRange(new object[] { "1日", "2日", "3日", "4日", "5日", "6日", "7日", "8日", "9日", "10日", "11日", "12日", "13日", "14日", "15日", "16日", "17日", "18日", "19日", "20日", "21日", "22日", "23日", "24日", "25日", "26日", "27日", "28日", "29日", "30日", "31日" });
            CboDates_Yearly.Location = new Point(6, 128);
            CboDates_Yearly.Name = "CboDates_Yearly";
            CboDates_Yearly.Size = new Size(151, 33);
            CboDates_Yearly.TabIndex = 1;
            // 
            // ChkMonth
            // 
            ChkMonth.FormattingEnabled = true;
            ChkMonth.Items.AddRange(new object[] { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" });
            ChkMonth.Location = new Point(6, 6);
            ChkMonth.MultiColumn = true;
            ChkMonth.Name = "ChkMonth";
            ChkMonth.Size = new Size(580, 116);
            ChkMonth.TabIndex = 0;
            // 
            // TbpMonthly
            // 
            TbpMonthly.Controls.Add(TpMonthly);
            TbpMonthly.Controls.Add(CboDates_Monthly);
            TbpMonthly.Location = new Point(4, 34);
            TbpMonthly.Name = "TbpMonthly";
            TbpMonthly.Padding = new Padding(3);
            TbpMonthly.Size = new Size(592, 188);
            TbpMonthly.TabIndex = 2;
            TbpMonthly.Text = "每月";
            TbpMonthly.UseVisualStyleBackColor = true;
            // 
            // TbpWeekly
            // 
            TbpWeekly.Controls.Add(TpWeekly);
            TbpWeekly.Controls.Add(ClbWeekDays);
            TbpWeekly.Location = new Point(4, 28);
            TbpWeekly.Name = "TbpWeekly";
            TbpWeekly.Padding = new Padding(3);
            TbpWeekly.Size = new Size(592, 194);
            TbpWeekly.TabIndex = 3;
            TbpWeekly.Text = "每週";
            TbpWeekly.UseVisualStyleBackColor = true;
            // 
            // TpWeekly
            // 
            TpWeekly.Format = DateTimePickerFormat.Time;
            TpWeekly.Location = new Point(6, 100);
            TpWeekly.Name = "TpWeekly";
            TpWeekly.Size = new Size(250, 33);
            TpWeekly.TabIndex = 3;
            // 
            // ClbWeekDays
            // 
            ClbWeekDays.FormattingEnabled = true;
            ClbWeekDays.Items.AddRange(new object[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" });
            ClbWeekDays.Location = new Point(6, 6);
            ClbWeekDays.MultiColumn = true;
            ClbWeekDays.Name = "ClbWeekDays";
            ClbWeekDays.Size = new Size(580, 88);
            ClbWeekDays.TabIndex = 1;
            // 
            // TbpDaily
            // 
            TbpDaily.Controls.Add(TpDaily);
            TbpDaily.Location = new Point(4, 28);
            TbpDaily.Name = "TbpDaily";
            TbpDaily.Padding = new Padding(3);
            TbpDaily.Size = new Size(592, 194);
            TbpDaily.TabIndex = 4;
            TbpDaily.Text = "每日";
            TbpDaily.UseVisualStyleBackColor = true;
            // 
            // TpDaily
            // 
            TpDaily.Format = DateTimePickerFormat.Time;
            TpDaily.Location = new Point(6, 6);
            TpDaily.Name = "TpDaily";
            TpDaily.Size = new Size(250, 33);
            TpDaily.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 0;
            label3.Text = "舉辦時間:";
            // 
            // TpMonthly
            // 
            TpMonthly.Format = DateTimePickerFormat.Time;
            TpMonthly.Location = new Point(163, 6);
            TpMonthly.Name = "TpMonthly";
            TpMonthly.Size = new Size(250, 33);
            TpMonthly.TabIndex = 4;
            // 
            // CboDates_Monthly
            // 
            CboDates_Monthly.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDates_Monthly.FormattingEnabled = true;
            CboDates_Monthly.Items.AddRange(new object[] { "1日", "2日", "3日", "4日", "5日", "6日", "7日", "8日", "9日", "10日", "11日", "12日", "13日", "14日", "15日", "16日", "17日", "18日", "19日", "20日", "21日", "22日", "23日", "24日", "25日", "26日", "27日", "28日", "29日", "30日", "31日" });
            CboDates_Monthly.Location = new Point(6, 6);
            CboDates_Monthly.Name = "CboDates_Monthly";
            CboDates_Monthly.Size = new Size(151, 33);
            CboDates_Monthly.TabIndex = 3;
            // 
            // FrmEventSettingEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 389);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(RdoDaily);
            Controls.Add(RdoWeekly);
            Controls.Add(RdoMonthly);
            Controls.Add(RdoYearly);
            Controls.Add(RdoOnce);
            Controls.Add(label2);
            Controls.Add(TxtEventName);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmEventSettingEditor";
            Text = "FrmEventSettingEditor";
            tabControl1.ResumeLayout(false);
            TbpOnce.ResumeLayout(false);
            TbpYearly.ResumeLayout(false);
            TbpMonthly.ResumeLayout(false);
            TbpWeekly.ResumeLayout(false);
            TbpDaily.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private Label label1;
        private TextBox TxtEventName;
        private Label label2;
        private RadioButton RdoOnce;
        private RadioButton RdoYearly;
        private RadioButton RdoWeekly;
        private RadioButton RdoMonthly;
        private RadioButton RdoDaily;
        private TabControl tabControl1;
        private TabPage TbpOnce;
        private TabPage TbpYearly;
        private TabPage TbpMonthly;
        private TabPage TbpWeekly;
        private TabPage TbpDaily;
        private Label label3;
        private DateTimePicker DtpHoldTime_Once;
        private CheckedListBox ChkMonth;
        private ComboBox CboDates_Yearly;
        private CheckedListBox ClbWeekDays;
        private DateTimePicker TpYearly;
        private DateTimePicker TpWeekly;
        private DateTimePicker TpDaily;
        private DateTimePicker TpMonthly;
        private ComboBox CboDates_Monthly;
    }
}