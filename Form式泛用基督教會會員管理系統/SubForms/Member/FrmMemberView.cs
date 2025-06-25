using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form式泛用基督教會會員管理系統.SubForms.Member
{
    public partial class FrmMemberView : Form
    {
        public FrmMemberView()
        {
            InitializeComponent();
            LoadMemberData();
        }

        #region 私有函數
        /// <summary>載入會員資料</summary>
        public void LoadMemberData()
        {
            DgvMemberView.Rows.Clear();
            foreach (var md in ClsChurchDataSaver.GetMemberList())
            {
                DgvMemberView.Rows.Add(md.Id, md.Name, md.Baptized ? "是" : "否");
            }
        }
        #endregion
        /// <summary>新增教友(會員)</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmMemberEditor me = new();
            me.ShowDialog(this);
            LoadMemberData();
        }
        /// <summary>編輯教友(會員)資料</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvMemberView.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(DgvMemberView.SelectedCells[0].OwningRow.Cells[0].Value);
                FrmMemberEditor me = new(id);
                me.ShowDialog(this);
                LoadMemberData();
            }
            else
            {
                MessageBox.Show("請選擇要修改資料的教友。", "無法編輯教友資料", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
