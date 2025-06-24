using Form式泛用基督教會會員管理系統.SubForms.Account;

namespace Form式泛用基督教會會員管理系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TmrTime.Start();
        }
        /// <summary>
        /// Timer用來秀目前時間
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TickToShowCurrentTime(object sender, EventArgs e)
        {
            TsslTime.Text = DateTime.Now.ToString("主後yyyy年M月d日H時m分s秒");
        }
        /// <summary>登入。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiLogin_Click(object sender, EventArgs e)
        {
            FrmLogin FL = new();
            FL.ShowDialog(this);
        }
    }
}
