using System.Reflection;

namespace Form式泛用基督教會會員管理系統.SubForms.ChurchSystem
{
    public partial class FrmIdSelector : Form
    {
        private string _idPropertyName;
        private object _selectedItem;

        public object SelectedId { get; private set; }

        public FrmIdSelector(IEnumerable<object> items, string idPropertyName = "Id")
        {
            InitializeComponent();
            _idPropertyName = idPropertyName;
            DgvItemDisplay.DataSource = items.ToList();
            DgvItemDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvItemDisplay.MultiSelect = false;
            DgvItemDisplay.ReadOnly = true;
            DgvItemDisplay.AutoGenerateColumns = true;
        }
        /// <summary>關閉視窗。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>確定選擇。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (DgvItemDisplay.CurrentRow?.DataBoundItem is object item)
            {
                var prop = item.GetType().GetProperty(_idPropertyName, BindingFlags.Public | BindingFlags.Instance);
                if (prop != null)
                {
                    SelectedId = prop.GetValue(item);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show($"找不到屬性：{_idPropertyName}");
                }
            }
        }
    }
}
