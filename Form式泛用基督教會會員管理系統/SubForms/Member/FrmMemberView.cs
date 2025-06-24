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
            foreach(var md in ClsChurchDataSaver.GetMemberList())
            {
                DgvMemberView.Rows.Add(md.Id, md.Name, md.Baptized ? "是" : "否");
            }
        }
        #endregion
    }
}
