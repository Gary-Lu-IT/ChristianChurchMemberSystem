namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Users
{
    /// <summary>登入傳回值</summary>
    public class ClsLoginReturn
    {
        /// <summary>帳戶流水號</summary>
        public int Id { get; set; }
        /// <summary>登入者名稱</summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>角色</summary>
        public string Role { get; set; } = string.Empty;
    }
}
