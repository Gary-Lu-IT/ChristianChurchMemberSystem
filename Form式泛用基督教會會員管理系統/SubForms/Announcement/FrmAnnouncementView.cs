using API_AllPurposeChurchMemberControl.ChurchMemberAccess;

namespace Form式泛用基督教會會員管理系統.SubForms.Announcement
{
    public partial class FrmAnnouncementView : Form
    {
        public FrmAnnouncementView()
        {
            InitializeComponent();
            LoadAnnouncements();
        }
        /// <summary>載入公告</summary>
        private void LoadAnnouncements()
        {
            DgvAnnouncementView.Rows.Clear();
            foreach (var announcement in API_AllPurposeChurchMemberControl.ChurchMemberAccess.ClsChurchDataSaver.GetAnnouncements())
            {
                DgvAnnouncementView.Rows.Add(announcement.Id, announcement.Title, announcement.Content);
            }
        }
        /// <summary>新增鈕</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAnnouncementEditor editor = new();
            editor.ShowDialog(this);
            LoadAnnouncements();
        }
        /// <summary>修改鈕</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvAnnouncementView.SelectedCells.Count <= 0)
            {
                MessageBox.Show("請選擇要修改的公告。", "無法修改公告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(DgvAnnouncementView.SelectedCells[0].OwningRow.Cells[0].Value);
                FrmAnnouncementEditor editor = new(id);
                editor.ShowDialog(this);
                LoadAnnouncements();
            }
        }
        /// <summary>刪除鈕</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvAnnouncementView.SelectedCells.Count <= 0)
            {
                MessageBox.Show("請選擇要刪除的公告。", "無法刪除公告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("真要刪除這個公告的資料？", "刪除公告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                int id = Convert.ToInt32(DgvAnnouncementView.SelectedCells[0].OwningRow.Cells[0].Value);
                ClsChurchDataSaver.DeleteMember(id);
                LoadAnnouncements();
            }
        }        
    }
}
