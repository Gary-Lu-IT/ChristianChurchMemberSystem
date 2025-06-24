namespace Form式泛用基督教會會員管理系統.SubForms.Account
{
    partial class FrmLogin
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
            TxtLoginID = new TextBox();
            label2 = new Label();
            TxtPassword = new TextBox();
            BtnConfirm = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "帳號";
            // 
            // TxtLoginID
            // 
            TxtLoginID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtLoginID.Location = new Point(70, 45);
            TxtLoginID.Name = "TxtLoginID";
            TxtLoginID.PlaceholderText = "請輸入帳號";
            TxtLoginID.Size = new Size(401, 33);
            TxtLoginID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "密碼";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Location = new Point(70, 84);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "請輸入密碼";
            TxtPassword.Size = new Size(401, 33);
            TxtPassword.TabIndex = 3;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(277, 160);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 4;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(377, 160);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "離開";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 221);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtLoginID);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "使用者登入";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtLoginID;
        private Label label2;
        private TextBox TxtPassword;
        private Button BtnConfirm;
        private Button BtnCancel;
    }
}