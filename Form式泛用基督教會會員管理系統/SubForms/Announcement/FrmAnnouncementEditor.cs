using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Announcements;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Families;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;

namespace Form式泛用基督教會會員管理系統.SubForms.Announcement
{
    public partial class FrmAnnouncementEditor : Form
    {
        /// <summary>要編輯的目標公告ID</summary>
        public int? TargetAnnouncementId;
        public FrmAnnouncementEditor(int? AnnouncementId = null)
        {
            InitializeComponent();
            if (AnnouncementId.HasValue)
            {
                TargetAnnouncementId = AnnouncementId.Value;
                ClsAnnouncementData? AD = ClsChurchDataSaver.GetAnnouncementById(AnnouncementId.Value);
                if (AD != null)
                {
                    Text = "修改公告";
                    TxtTitle.Text = AD.Title;
                    TxtContent.Text = AD.Content;
                }
                else
                {
                    if (MessageBox.Show("找不到指定的公告。要改為新增新公告嗎？", "錯誤", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        MessageBox.Show("找不到指定的公告。將關閉視窗。", "無法修改公告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        Text = "新增公告";
                        TargetAnnouncementId = null;
                        TxtTitle.Text = string.Empty;
                        TxtContent.Text = string.Empty;
                    }
                }
            }
            else
            {
                Text = "新增公告";
            }
        }
        /// <summary>取消。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>確定處理。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetAnnouncementId.HasValue)
                {
                    ClsChurchDataSaver.UpdateAnnouncement(new ClsAnnouncementData
                    {
                        Id = TargetAnnouncementId.Value,
                        Title = TxtTitle.Text,
                        Content = TxtContent.Text
                    });
                    MessageBox.Show("公告已更新。", "公告編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClsChurchDataSaver.PublishAnnouncement(new ClsAnnouncementData
                    {
                        Title = TxtTitle.Text,
                        Content = TxtContent.Text
                    });
                    MessageBox.Show("公告已新增。", "公告編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
            catch (ChurchMemberException ex)
            {
                MessageBox.Show($"錯誤碼: {ex.Code}, 錯誤訊息: {ex.Message}", "公告編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤訊息: {ex.Message}", "公告編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
