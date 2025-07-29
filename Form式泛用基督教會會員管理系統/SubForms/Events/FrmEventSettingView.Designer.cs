namespace Form式泛用基督教會會員管理系統.SubForms.Events
{
    partial class FrmEventSettingView
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
            DgvEventSettingView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvEventSettingView).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Location = new Point(961, 122);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 49);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "刪除";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Location = new Point(961, 67);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 49);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.Location = new Point(961, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 49);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // DgvEventSettingView
            // 
            DgvEventSettingView.AllowUserToAddRows = false;
            DgvEventSettingView.AllowUserToDeleteRows = false;
            DgvEventSettingView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvEventSettingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEventSettingView.Location = new Point(12, 12);
            DgvEventSettingView.Name = "DgvEventSettingView";
            DgvEventSettingView.ReadOnly = true;
            DgvEventSettingView.RowHeadersWidth = 51;
            DgvEventSettingView.Size = new Size(943, 568);
            DgvEventSettingView.TabIndex = 14;
            // 
            // FrmEventSettingView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 592);
            Controls.Add(DgvEventSettingView);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmEventSettingView";
            Text = "FrmEventSettingView";
            ((System.ComponentModel.ISupportInitialize)DgvEventSettingView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnAdd;
        private DataGridView DgvEventSettingView;
    }
}