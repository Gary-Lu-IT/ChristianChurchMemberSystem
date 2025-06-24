using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Users;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using System.Net;
using System.Net.Sockets;

namespace Form式泛用基督教會會員管理系統.SubForms.Account
{
    /// <summary>登入框</summary>
    public partial class FrmLogin : Form
    {
        string CurrentIP = string.Empty;
        public FrmLogin()
        {
            InitializeComponent();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    CurrentIP=ip.ToString();
                }
            }
        }
        /// <summary>關閉本視窗</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>確定登入</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ClsLoginReturn LR = ClsChurchDataSaver.UserLogin(new ClsLoginParam
                {
                    LoginId = TxtLoginID.Text,
                    Password = TxtPassword.Text,
                    IPAddress = CurrentIP
                });
                MessageBox.Show("成功。", "登入作業", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(ChurchMemberException ex)
            {
                MessageBox.Show($"錯誤碼: {ex.Code}, 錯誤訊息: {ex.Message}", "登入作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"錯誤訊息: {ex.Message}", "登入作業", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
