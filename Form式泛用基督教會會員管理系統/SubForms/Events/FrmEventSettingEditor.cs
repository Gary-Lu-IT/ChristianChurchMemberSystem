using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form式泛用基督教會會員管理系統.SubForms.Events
{
    public partial class FrmEventSettingEditor : Form
    {
        public FrmEventSettingEditor()
        {
            InitializeComponent();
        }
        /// <summary>活動頻率設定RadioButtons切換選擇時的事件</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoFrequenciesCheckedChanged(object sender, EventArgs e)
        {
            TbpDaily.Visible = RdoDaily.Checked;
            TbpWeekly.Visible = RdoWeekly.Checked;
            TbpMonthly.Visible = RdoMonthly.Checked;
            TbpYearly.Visible = RdoYearly.Checked;
            TbpOnce.Visible = RdoOnce.Checked;
        }
    }
}
