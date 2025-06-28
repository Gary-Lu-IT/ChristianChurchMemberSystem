using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using Form式泛用基督教會會員管理系統.SubForms.Member;

namespace Form式泛用基督教會會員管理系統.SubForms.Family
{
    public partial class FrmFamilyView : Form
    {
        public FrmFamilyView()
        {
            InitializeComponent();
            LoadFamily();
        }
        private void LoadFamily()
        {
            DgvFamilyView.Rows.Clear();
            foreach(var family in ClsChurchDataSaver.GetFamilyList())
            {
                DgvFamilyView.Rows.Add(family.Id, family.FamilyName, family.FamilyAddress, family.FamilyPhone);
            }
        }
        /// <summary>新增家庭</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmFamilyEditor FFE = new();
            FFE.ShowDialog();
            LoadFamily();
        }
        /// <summary>刪除家庭</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvFamilyView.SelectedCells.Count <= 0)
            {
                MessageBox.Show("請選擇要刪除的家庭。", "無法刪除家庭資料", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("真要刪除這個家庭的資料？", "刪除家庭資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                int id = Convert.ToInt32(DgvFamilyView.SelectedCells[0].OwningRow.Cells[0].Value);
                ClsChurchDataSaver.DeleteMember(id);
                LoadFamily();
            }
        }
        /// <summary>
        /// 修改家族資料。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvFamilyView.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(DgvFamilyView.SelectedCells[0].OwningRow.Cells[0].Value);
                FrmFamilyEditor me = new(id);
                me.ShowDialog(this);
                LoadFamily();
            }
            else
            {
                MessageBox.Show("請選擇要修改資料的家庭。", "無法編輯家庭資料", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
