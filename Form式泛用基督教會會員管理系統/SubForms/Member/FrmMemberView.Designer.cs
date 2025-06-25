namespace Form式泛用基督教會會員管理系統.SubForms.Member
{
    partial class FrmMemberView
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
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            DgvMemberView = new DataGridView();
            編號 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            是否受洗 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvMemberView).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAdd.Location = new Point(677, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 49);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnEdit.Location = new Point(677, 67);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 49);
            BtnEdit.TabIndex = 6;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDelete.Location = new Point(677, 122);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 49);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "刪除";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // DgvMemberView
            // 
            DgvMemberView.AllowUserToAddRows = false;
            DgvMemberView.AllowUserToDeleteRows = false;
            DgvMemberView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMemberView.Columns.AddRange(new DataGridViewColumn[] { 編號, 姓名, 是否受洗 });
            DgvMemberView.Location = new Point(12, 12);
            DgvMemberView.Name = "DgvMemberView";
            DgvMemberView.ReadOnly = true;
            DgvMemberView.RowHeadersWidth = 51;
            DgvMemberView.Size = new Size(659, 407);
            DgvMemberView.TabIndex = 8;
            // 
            // 編號
            // 
            編號.HeaderText = "編號";
            編號.MinimumWidth = 6;
            編號.Name = "編號";
            編號.ReadOnly = true;
            編號.Width = 125;
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.MinimumWidth = 6;
            姓名.Name = "姓名";
            姓名.ReadOnly = true;
            姓名.Width = 125;
            // 
            // 是否受洗
            // 
            是否受洗.HeaderText = "是否受洗";
            是否受洗.MinimumWidth = 6;
            是否受洗.Name = "是否受洗";
            是否受洗.ReadOnly = true;
            是否受洗.Width = 125;
            // 
            // FrmMemberView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 431);
            Controls.Add(DgvMemberView);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmMemberView";
            ShowIcon = false;
            Text = "教友資料清單";
            ((System.ComponentModel.ISupportInitialize)DgvMemberView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private DataGridView DgvMemberView;
        private DataGridViewTextBoxColumn 編號;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 是否受洗;
    }
}