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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            使用者帳號AToolStripMenuItem = new ToolStripMenuItem();
            TsmiLogin = new ToolStripMenuItem();
            教友MToolStripMenuItem = new ToolStripMenuItem();
            TsmiMemberList = new ToolStripMenuItem();
            TsmiFamilyList = new ToolStripMenuItem();
            TsmiPrayerRequests = new ToolStripMenuItem();
            系統SToolStripMenuItem = new ToolStripMenuItem();
            TsmiAnnouncements = new ToolStripMenuItem();
            活動管理EToolStripMenuItem = new ToolStripMenuItem();
            TsmiEventScheduleSetting = new ToolStripMenuItem();
            TsmiActivityBasis = new ToolStripMenuItem();
            TsmiActivityCheckIn = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { 使用者帳號AToolStripMenuItem, 教友MToolStripMenuItem, 系統SToolStripMenuItem, 活動管理EToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 使用者帳號AToolStripMenuItem
            // 
            使用者帳號AToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmiLogin });
            使用者帳號AToolStripMenuItem.Name = "使用者帳號AToolStripMenuItem";
            使用者帳號AToolStripMenuItem.Size = new Size(118, 23);
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
            教友MToolStripMenuItem.Size = new Size(107, 23);
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
            系統SToolStripMenuItem.Size = new Size(72, 23);
            系統SToolStripMenuItem.Text = "系統(&S)";
            // 
            // TsmiAnnouncements
            // 
            TsmiAnnouncements.Name = "TsmiAnnouncements";
            TsmiAnnouncements.Size = new Size(172, 26);
            TsmiAnnouncements.Text = "公告列表(&A)";
            TsmiAnnouncements.Click += TsmiAnnouncements_Click;
            // 
            // 活動管理EToolStripMenuItem
            // 
            活動管理EToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmiEventScheduleSetting, TsmiActivityBasis, TsmiActivityCheckIn });
            活動管理EToolStripMenuItem.Name = "活動管理EToolStripMenuItem";
            活動管理EToolStripMenuItem.Size = new Size(101, 23);
            活動管理EToolStripMenuItem.Text = "活動管理(&E)";
            // 
            // TsmiEventScheduleSetting
            // 
            TsmiEventScheduleSetting.Name = "TsmiEventScheduleSetting";
            TsmiEventScheduleSetting.Size = new Size(201, 26);
            TsmiEventScheduleSetting.Text = "活動排程設定(&S)";
            // 
            // TsmiActivityBasis
            // 
            TsmiActivityBasis.Name = "TsmiActivityBasis";
            TsmiActivityBasis.Size = new Size(201, 26);
            TsmiActivityBasis.Text = "活動資料(&A)";
            // 
            // TsmiActivityCheckIn
            // 
            TsmiActivityCheckIn.Name = "TsmiActivityCheckIn";
            TsmiActivityCheckIn.Size = new Size(201, 26);
            TsmiActivityCheckIn.Text = "活動簽到(&C)";
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem 活動管理EToolStripMenuItem;
        private ToolStripMenuItem TsmiEventScheduleSetting;
        private ToolStripMenuItem TsmiActivityBasis;
        private ToolStripMenuItem TsmiActivityCheckIn;
    }
}
