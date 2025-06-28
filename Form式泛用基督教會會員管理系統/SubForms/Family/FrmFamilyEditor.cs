using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Family;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;

namespace Form式泛用基督教會會員管理系統.SubForms.Family
{
    public partial class FrmFamilyEditor : Form
    {
        int? TargetFamilyId = null;
        public FrmFamilyEditor(int? FamilyId = null)
        {
            InitializeComponent();
            Text = FamilyId.HasValue ? "編輯家庭" : "新增家庭";
            TargetFamilyId = FamilyId;
            if (FamilyId.HasValue)
            {
                ClsFamilies? Family = ClsChurchDataSaver.GetFamilyById(FamilyId.Value);
                Text = Family == null ? "新增家庭" : "編輯家庭 - " + Family.FamilyName;
                if (Family != null)
                {
                    TxtFamilyName.Text = Family.FamilyName;
                    TxtFamilyName.ReadOnly = true; // 假設編輯時不允許修改家庭名稱
                    TxtAddress.Text = Family.FamilyAddress;
                    TxtPhone.Text = Family.FamilyPhone;
                }
            }
        }
        /// <summary>取消編輯/新增</summary>
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
                if (TxtFamilyName.ReadOnly)
                {
                    ClsChurchDataSaver.UpdateFamily(new ClsFamilies
                    {
                        Id = TargetFamilyId.Value,
                        FamilyName = TxtFamilyName.Text,
                        FamilyAddress = TxtAddress.Text,
                        FamilyPhone = TxtPhone.Text
                    });
                    MessageBox.Show("家庭資料已更新。", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ClsChurchDataSaver.AddFamily(new ClsFamilies
                    {
                        FamilyName = TxtFamilyName.Text,
                        FamilyAddress = TxtAddress.Text,
                        FamilyPhone = TxtPhone.Text
                    });
                    MessageBox.Show("家庭資料已新增。", "教友資料編輯作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
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
