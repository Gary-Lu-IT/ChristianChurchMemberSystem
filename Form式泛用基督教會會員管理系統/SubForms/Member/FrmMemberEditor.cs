using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;

namespace Form式泛用基督教會會員管理系統.SubForms.Member
{
    public partial class FrmMemberEditor : Form
    {
        /// <summary>要編輯的教友(會員)資料</summary>
        ClsMemberData? TargetMemberData;
        public FrmMemberEditor(int? GetMemberId = null)
        {
            InitializeComponent();
            if (GetMemberId != null)
            {
                TargetMemberData = ClsChurchDataSaver.GetMemberById(GetMemberId.Value);
                if (TargetMemberData == null)
                {
                    MessageBox.Show("教友資料不存在無法編輯！將進入新增教友資料模式。", "編輯教友資料", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        /// <summary>取消/離開。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
