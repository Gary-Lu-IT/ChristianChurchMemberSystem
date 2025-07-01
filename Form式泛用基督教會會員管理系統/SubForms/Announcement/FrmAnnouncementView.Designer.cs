namespace Form式泛用基督教會會員管理系統.SubForms.Announcement
{
    partial class FrmAnnouncementView
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
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnAdd = new Button();
            DgvAnnouncementView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TITLE = new DataGridViewTextBoxColumn();
            CONTENT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvAnnouncementView).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Location = new Point(714, 122);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 49);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "刪除";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Location = new Point(714, 67);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 49);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.Location = new Point(714, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 49);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // DgvAnnouncementView
            // 
            DgvAnnouncementView.AllowUserToAddRows = false;
            DgvAnnouncementView.AllowUserToDeleteRows = false;
            DgvAnnouncementView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvAnnouncementView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAnnouncementView.Columns.AddRange(new DataGridViewColumn[] { Id, TITLE, CONTENT });
            DgvAnnouncementView.Location = new Point(12, 12);
            DgvAnnouncementView.Name = "DgvAnnouncementView";
            DgvAnnouncementView.ReadOnly = true;
            DgvAnnouncementView.RowHeadersWidth = 51;
            DgvAnnouncementView.Size = new Size(696, 384);
            DgvAnnouncementView.TabIndex = 14;
            // 
            // Id
            // 
            Id.HeaderText = "編號";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // TITLE
            // 
            TITLE.HeaderText = "主旨";
            TITLE.MinimumWidth = 6;
            TITLE.Name = "TITLE";
            TITLE.ReadOnly = true;
            TITLE.Width = 150;
            // 
            // CONTENT
            // 
            CONTENT.HeaderText = "內容";
            CONTENT.MinimumWidth = 6;
            CONTENT.Name = "CONTENT";
            CONTENT.ReadOnly = true;
            CONTENT.Width = 300;
            // 
            // FrmAnnouncementView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 408);
            Controls.Add(DgvAnnouncementView);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmAnnouncementView";
            Text = "系統公告清單";
            ((System.ComponentModel.ISupportInitialize)DgvAnnouncementView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnAdd;
        private DataGridView DgvAnnouncementView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TITLE;
        private DataGridViewTextBoxColumn CONTENT;
    }
}