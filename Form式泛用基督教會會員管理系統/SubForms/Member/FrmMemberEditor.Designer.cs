namespace Form式泛用基督教會會員管理系統.SubForms.Member
{
    partial class FrmMemberEditor
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
            label1 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            RdoMan = new RadioButton();
            RdoWoman = new RadioButton();
            label3 = new Label();
            DtpBirthday = new DateTimePicker();
            label4 = new Label();
            TxtPhone = new TextBox();
            TxtEMail = new TextBox();
            label5 = new Label();
            TxtAddress = new TextBox();
            label6 = new Label();
            ChkBaptized = new CheckBox();
            label7 = new Label();
            DtpBaptizedDate = new DateTimePicker();
            BtnCancel = new Button();
            BtnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 28);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(150, 20);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(250, 33);
            TxtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 28);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "性別";
            // 
            // RdoMan
            // 
            RdoMan.AutoSize = true;
            RdoMan.Checked = true;
            RdoMan.Location = new Point(563, 24);
            RdoMan.Name = "RdoMan";
            RdoMan.Size = new Size(53, 29);
            RdoMan.TabIndex = 3;
            RdoMan.TabStop = true;
            RdoMan.Text = "男";
            RdoMan.UseVisualStyleBackColor = true;
            // 
            // RdoWoman
            // 
            RdoWoman.AutoSize = true;
            RdoWoman.Location = new Point(622, 24);
            RdoWoman.Name = "RdoWoman";
            RdoWoman.Size = new Size(53, 29);
            RdoWoman.TabIndex = 4;
            RdoWoman.Text = "女";
            RdoWoman.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 68);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 5;
            label3.Text = "出生年月日";
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(150, 62);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(250, 33);
            DtpBirthday.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 62);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 7;
            label4.Text = "電話號碼";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(563, 59);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(250, 33);
            TxtPhone.TabIndex = 8;
            // 
            // TxtEMail
            // 
            TxtEMail.Location = new Point(150, 101);
            TxtEMail.Name = "TxtEMail";
            TxtEMail.Size = new Size(663, 33);
            TxtEMail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 9;
            label5.Text = "電子郵件信箱";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(150, 140);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(663, 33);
            TxtAddress.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 143);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 11;
            label6.Text = "地址";
            // 
            // ChkBaptized
            // 
            ChkBaptized.AutoSize = true;
            ChkBaptized.Location = new Point(150, 186);
            ChkBaptized.Name = "ChkBaptized";
            ChkBaptized.Size = new Size(94, 29);
            ChkBaptized.TabIndex = 13;
            ChkBaptized.Text = "已受洗";
            ChkBaptized.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 186);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 14;
            label7.Text = "日期：";
            // 
            // DtpBaptizedDate
            // 
            DtpBaptizedDate.Location = new Point(328, 180);
            DtpBaptizedDate.Name = "DtpBaptizedDate";
            DtpBaptizedDate.Size = new Size(250, 33);
            DtpBaptizedDate.TabIndex = 15;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(760, 321);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 17;
            BtnCancel.Text = "離開";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(660, 321);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 16;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // FrmMemberEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 382);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(DtpBaptizedDate);
            Controls.Add(label7);
            Controls.Add(ChkBaptized);
            Controls.Add(TxtAddress);
            Controls.Add(label6);
            Controls.Add(TxtEMail);
            Controls.Add(label5);
            Controls.Add(TxtPhone);
            Controls.Add(label4);
            Controls.Add(DtpBirthday);
            Controls.Add(label3);
            Controls.Add(RdoWoman);
            Controls.Add(RdoMan);
            Controls.Add(label2);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMemberEditor";
            ShowIcon = false;
            Text = "FrmMemberEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private Label label2;
        private RadioButton RdoMan;
        private RadioButton RdoWoman;
        private Label label3;
        private DateTimePicker DtpBirthday;
        private Label label4;
        private TextBox TxtPhone;
        private TextBox TxtEMail;
        private Label label5;
        private TextBox TxtAddress;
        private Label label6;
        private CheckBox ChkBaptized;
        private Label label7;
        private DateTimePicker DtpBaptizedDate;
        private Button BtnCancel;
        private Button BtnConfirm;
    }
}