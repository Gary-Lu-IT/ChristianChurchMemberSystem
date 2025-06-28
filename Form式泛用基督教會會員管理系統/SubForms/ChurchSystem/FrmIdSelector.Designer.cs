namespace Form式泛用基督教會會員管理系統.SubForms.ChurchSystem
{
    partial class FrmIdSelector
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
            DgvItemDisplay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvItemDisplay).BeginInit();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(882, 421);
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
            BtnConfirm.Location = new Point(782, 421);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 49);
            BtnConfirm.TabIndex = 20;
            BtnConfirm.Text = "確定";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // DgvItemDisplay
            // 
            DgvItemDisplay.AllowUserToAddRows = false;
            DgvItemDisplay.AllowUserToDeleteRows = false;
            DgvItemDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvItemDisplay.Location = new Point(12, 12);
            DgvItemDisplay.Name = "DgvItemDisplay";
            DgvItemDisplay.ReadOnly = true;
            DgvItemDisplay.RowHeadersWidth = 51;
            DgvItemDisplay.Size = new Size(964, 403);
            DgvItemDisplay.TabIndex = 22;
            // 
            // FrmIdSelector
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 482);
            Controls.Add(DgvItemDisplay);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmIdSelector";
            Text = "FrmIdSelector";
            ((System.ComponentModel.ISupportInitialize)DgvItemDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private DataGridView DgvItemDisplay;
    }
}