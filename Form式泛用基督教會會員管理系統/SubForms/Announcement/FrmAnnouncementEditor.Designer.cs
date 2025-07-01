namespace Form式泛用基督教會會員管理系統.SubForms.Announcement
{
    partial class FrmAnnouncementEditor
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
            TxtTitle = new TextBox();
            TxtContent = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(533, 245);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 49);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "離開";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(433, 245);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 20;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 22;
            label1.Text = "公告主旨";
            // 
            // TxtTitle
            // 
            TxtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTitle.Location = new Point(110, 12);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(517, 33);
            TxtTitle.TabIndex = 23;
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(110, 51);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.Size = new Size(517, 188);
            TxtContent.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 25;
            label2.Text = "公告內容";
            // 
            // FrmAnnouncementEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 306);
            Controls.Add(label2);
            Controls.Add(TxtContent);
            Controls.Add(TxtTitle);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmAnnouncementEditor";
            Text = "FrmAnnouncementEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private Label label1;
        private TextBox TxtTitle;
        private TextBox TxtContent;
        private Label label2;
    }
}