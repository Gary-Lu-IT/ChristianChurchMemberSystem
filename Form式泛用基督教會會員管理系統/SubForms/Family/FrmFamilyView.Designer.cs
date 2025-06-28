namespace Form式泛用基督教會會員管理系統.SubForms.Family
{
    partial class FrmFamilyView
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
            DgvFamilyView = new DataGridView();
            FAMILYID = new DataGridViewTextBoxColumn();
            FAMILYNAME = new DataGridViewTextBoxColumn();
            FAMILYTEL = new DataGridViewTextBoxColumn();
            FAMILYADDR = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvFamilyView).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Location = new Point(721, 122);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 49);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "刪除";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Location = new Point(721, 67);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 49);
            BtnEdit.TabIndex = 9;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.Location = new Point(721, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 49);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // DgvFamilyView
            // 
            DgvFamilyView.AllowUserToAddRows = false;
            DgvFamilyView.AllowUserToDeleteRows = false;
            DgvFamilyView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvFamilyView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFamilyView.Columns.AddRange(new DataGridViewColumn[] { FAMILYID, FAMILYNAME, FAMILYTEL, FAMILYADDR });
            DgvFamilyView.Location = new Point(12, 12);
            DgvFamilyView.Name = "DgvFamilyView";
            DgvFamilyView.ReadOnly = true;
            DgvFamilyView.RowHeadersWidth = 51;
            DgvFamilyView.Size = new Size(703, 433);
            DgvFamilyView.TabIndex = 11;
            // 
            // FAMILYID
            // 
            FAMILYID.HeaderText = "家庭編號";
            FAMILYID.MinimumWidth = 6;
            FAMILYID.Name = "FAMILYID";
            FAMILYID.ReadOnly = true;
            FAMILYID.Width = 125;
            // 
            // FAMILYNAME
            // 
            FAMILYNAME.HeaderText = "家庭名稱";
            FAMILYNAME.MinimumWidth = 6;
            FAMILYNAME.Name = "FAMILYNAME";
            FAMILYNAME.ReadOnly = true;
            FAMILYNAME.Width = 125;
            // 
            // FAMILYTEL
            // 
            FAMILYTEL.HeaderText = "電話";
            FAMILYTEL.MinimumWidth = 6;
            FAMILYTEL.Name = "FAMILYTEL";
            FAMILYTEL.ReadOnly = true;
            FAMILYTEL.Width = 150;
            // 
            // FAMILYADDR
            // 
            FAMILYADDR.HeaderText = "地址";
            FAMILYADDR.MinimumWidth = 6;
            FAMILYADDR.Name = "FAMILYADDR";
            FAMILYADDR.ReadOnly = true;
            FAMILYADDR.Width = 375;
            // 
            // FrmFamilyView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 457);
            Controls.Add(DgvFamilyView);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmFamilyView";
            Text = "家庭資料清單";
            ((System.ComponentModel.ISupportInitialize)DgvFamilyView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnAdd;
        private DataGridView DgvFamilyView;
        private DataGridViewTextBoxColumn FAMILYID;
        private DataGridViewTextBoxColumn FAMILYNAME;
        private DataGridViewTextBoxColumn FAMILYTEL;
        private DataGridViewTextBoxColumn FAMILYADDR;
    }
}