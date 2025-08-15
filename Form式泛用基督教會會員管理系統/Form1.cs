using Form式泛用基督教會會員管理系統.SubForms.Account;
using Form式泛用基督教會會員管理系統.SubForms.Announcement;
using Form式泛用基督教會會員管理系統.SubForms.Events;
using Form式泛用基督教會會員管理系統.SubForms.Family;
using Form式泛用基督教會會員管理系統.SubForms.Member;

namespace Form式泛用基督教會會員管理系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TmrTime.Start();
        }
        /// <summary>
        /// Timer用來秀目前時間
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TickToShowCurrentTime(object sender, EventArgs e)
        {
            TsslTime.Text = DateTime.Now.ToString("主後yyyy年M月d日H時m分s秒");
        }
        /// <summary>登入。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiLogin_Click(object sender, EventArgs e)
        {
            FrmLogin FL = new();
            FL.ShowDialog(this);
        }
        /// <summary>教友列表。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiMemberList_Click(object sender, EventArgs e)
        {
            bool FormFound = false;
            foreach (Form F in this.MdiChildren)
            {
                if (F.Name == "FrmMemberList")
                {
                    F.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (!FormFound)
            {
                FrmMemberView MV = new();
                MV.MdiParent = this;
                MV.Show();
            }
        }
        /// <summary>
        /// 家庭列表。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiFamilyList_Click(object sender, EventArgs e)
        {
            bool FormFound = false;
            foreach (Form F in this.MdiChildren)
            {
                if (F.Name == "FrmFamilyView")
                {
                    F.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (!FormFound)
            {
                FrmFamilyView MV = new();
                MV.MdiParent = this;
                MV.Show();
            }
        }
        /// <summary>系統公告列表</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiAnnouncements_Click(object sender, EventArgs e)
        {
            bool FormFound = false;
            foreach (Form F in this.MdiChildren)
            {
                if (F.Name == "FrmAnnouncementView")
                {
                    F.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (!FormFound)
            {
                FrmAnnouncementView AV = new();
                AV.MdiParent = this;
                AV.Show();
            }
        }
        /// <summary>活動排程設定</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiEventScheduleSetting_Click(object sender, EventArgs e)
        {
            bool FormFound = false;
            foreach (Form F in this.MdiChildren)
            {
                if (F.Name == "FrmEventSettingView")
                {
                    F.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (!FormFound)
            {
                FrmEventSettingView ESV = new();
                ESV.MdiParent = this;
                ESV.Show();
            }
        }
    }
}
