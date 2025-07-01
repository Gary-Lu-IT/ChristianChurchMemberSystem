namespace Form式泛用基督教會會員管理系統
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            使用者帳號AToolStripMenuItem = new ToolStripMenuItem();
            TsmiLogin = new ToolStripMenuItem();
            教友MToolStripMenuItem = new ToolStripMenuItem();
            TsmiMemberList = new ToolStripMenuItem();
            TsmiFamilyList = new ToolStripMenuItem();
            TsmiPrayerRequests = new ToolStripMenuItem();
            系統SToolStripMenuItem = new ToolStripMenuItem();
            TsmiAnnouncements = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            TsslTime = new ToolStripStatusLabel();
            TmrTime = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 使用者帳號AToolStripMenuItem, 教友MToolStripMenuItem, 系統SToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 使用者帳號AToolStripMenuItem
            // 
            使用者帳號AToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmiLogin });
            使用者帳號AToolStripMenuItem.Name = "使用者帳號AToolStripMenuItem";
            使用者帳號AToolStripMenuItem.Size = new Size(118, 24);
            使用者帳號AToolStripMenuItem.Text = "使用者帳號(&A)";
            // 
            // TsmiLogin
            // 
            TsmiLogin.Name = "TsmiLogin";
            TsmiLogin.Size = new Size(136, 26);
            TsmiLogin.Text = "登入(&I)";
            TsmiLogin.Click += TsmiLogin_Click;
            // 
            // 教友MToolStripMenuItem
            // 
            教友MToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmiMemberList, TsmiFamilyList, TsmiPrayerRequests });
            教友MToolStripMenuItem.Name = "教友MToolStripMenuItem";
            教友MToolStripMenuItem.Size = new Size(107, 24);
            教友MToolStripMenuItem.Text = "教友管理(&M)";
            // 
            // TsmiMemberList
            // 
            TsmiMemberList.Name = "TsmiMemberList";
            TsmiMemberList.Size = new Size(201, 26);
            TsmiMemberList.Text = "教友資料列表(&L)";
            TsmiMemberList.Click += TsmiMemberList_Click;
            // 
            // TsmiFamilyList
            // 
            TsmiFamilyList.Name = "TsmiFamilyList";
            TsmiFamilyList.Size = new Size(201, 26);
            TsmiFamilyList.Text = "家庭資料列表(&F)";
            TsmiFamilyList.Click += TsmiFamilyList_Click;
            // 
            // TsmiPrayerRequests
            // 
            TsmiPrayerRequests.Name = "TsmiPrayerRequests";
            TsmiPrayerRequests.Size = new Size(201, 26);
            TsmiPrayerRequests.Text = "代禱事項列表(&P)";
            // 
            // 系統SToolStripMenuItem
            // 
            系統SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmiAnnouncements });
            系統SToolStripMenuItem.Name = "系統SToolStripMenuItem";
            系統SToolStripMenuItem.Size = new Size(72, 24);
            系統SToolStripMenuItem.Text = "系統(&S)";
            // 
            // TsmiAnnouncements
            // 
            TsmiAnnouncements.Name = "TsmiAnnouncements";
            TsmiAnnouncements.Size = new Size(224, 26);
            TsmiAnnouncements.Text = "公告列表(&A)";
            TsmiAnnouncements.Click += TsmiAnnouncements_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { TsslTime });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // TsslTime
            // 
            TsslTime.Name = "TsslTime";
            TsslTime.Size = new Size(21, 19);
            TsslTime.Text = "   ";
            // 
            // TmrTime
            // 
            TmrTime.Tick += TickToShowCurrentTime;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "汎用基督教會會員管理系統(視窗版)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer TmrTime;
        private ToolStripStatusLabel TsslTime;
        private ToolStripMenuItem 使用者帳號AToolStripMenuItem;
        private ToolStripMenuItem TsmiLogin;
        private ToolStripMenuItem 教友MToolStripMenuItem;
        private ToolStripMenuItem TsmiMemberList;
        private ToolStripMenuItem TsmiFamilyList;
        private ToolStripMenuItem TsmiPrayerRequests;
        private ToolStripMenuItem 系統SToolStripMenuItem;
        private ToolStripMenuItem TsmiAnnouncements;
    }
}
