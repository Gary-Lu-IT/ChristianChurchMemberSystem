using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;

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
                else
                {
                    TxtName.Text = TargetMemberData.memberName;
                    if (TargetMemberData.Birthdate != null)
                    {
                        DtpBirthday.Value = TargetMemberData.Birthdate.Value;
                    }
                    RdoMan.Checked = TargetMemberData.Gender == "男";
                    RdoWoman.Checked = !RdoMan.Checked;
                    TxtPhone.Text= TargetMemberData.Phone;
                    TxtEMail.Text = TargetMemberData.Email;
                    TxtAddress.Text= TargetMemberData.Address;
                    ChkBaptized.Checked = TargetMemberData.Baptized;
                    if (TargetMemberData.BaptismDate != null)
                    {
                        DtpBaptizedDate.Value = TargetMemberData.BaptismDate.Value;
                    }
                    TxtGroupName.Text= TargetMemberData.GroupName;
                    TxtNotes.Text= TargetMemberData.Notes;
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
        /// <summary>確定編輯/新增</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetMemberData == null)
                {
                    //新增模式
                    ClsChurchDataSaver.AddMember(new ClsMemberData
                    {
                        memberName = TxtName.Text,
                        Gender = RdoMan.Checked ? "男" : "女",
                        Birthdate = DtpBirthday.Value,
                        Phone = TxtPhone.Text,
                        Email = TxtEMail.Text,
                        Address = TxtAddress.Text,
                        Baptized = ChkBaptized.Checked,
                        BaptismDate = ChkBaptized.Checked ? DtpBaptizedDate.Value : null,
                        GroupName = TxtGroupName.Text,
                        Notes = TxtNotes.Text
                    });
                    MessageBox.Show("新增成功。", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    //編輯模式
                    ClsChurchDataSaver.UpdateMember(new ClsMemberData
                    {
                        Id=TargetMemberData.Id,
                        memberName = TxtName.Text,
                        Gender = RdoMan.Checked ? "男" : "女",
                        Birthdate = DtpBirthday.Value,
                        Phone = TxtPhone.Text,
                        Email = TxtEMail.Text,
                        Address = TxtAddress.Text,
                        Baptized = ChkBaptized.Checked,
                        BaptismDate = ChkBaptized.Checked ? DtpBaptizedDate.Value : null,
                        GroupName = TxtGroupName.Text,
                        Notes = TxtNotes.Text
                    });
                    MessageBox.Show("修改成功。", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (ChurchMemberException ex)
            {
                MessageBox.Show($"錯誤碼: {ex.Code}, 錯誤訊息: {ex.Message}", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤訊息: {ex.Message}", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
