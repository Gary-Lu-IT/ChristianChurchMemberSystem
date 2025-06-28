namespace Form式泛用基督教會會員管理系統.SubForms.Family
{
    partial class FrmFamilyEditor
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
            TxtFamilyName = new TextBox();
            TxtPhone = new TextBox();
            label2 = new Label();
            TxtAddress = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(496, 285);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 19;
            BtnCancel.Text = "離開";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(396, 285);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 18;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 20;
            label1.Text = "家庭名稱";
            // 
            // TxtFamilyName
            // 
            TxtFamilyName.Location = new Point(110, 33);
            TxtFamilyName.Name = "TxtFamilyName";
            TxtFamilyName.Size = new Size(282, 33);
            TxtFamilyName.TabIndex = 21;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(110, 81);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(282, 33);
            TxtPhone.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 23;
            label2.Text = "連絡電話";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(110, 129);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(480, 129);
            TxtAddress.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 25;
            label3.Text = "地址";
            // 
            // FrmFamilyEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 346);
            Controls.Add(label3);
            Controls.Add(TxtAddress);
            Controls.Add(label2);
            Controls.Add(TxtPhone);
            Controls.Add(TxtFamilyName);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFamilyEditor";
            Text = "FrmFamilyEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private Label label1;
        private TextBox TxtFamilyName;
        private TextBox TxtPhone;
        private Label label2;
        private TextBox TxtAddress;
        private Label label3;
    }
}