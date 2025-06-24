namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Users
{
    /// <summary>登入參數</summary>
    public class ClsLoginParam
    {
        /// <summary>登入帳號</summary>
        public string LoginId { get; set; } = string.Empty;
        /// <summary>登入密碼</summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>IP位址</summary>
        public string IPAddress { get; set; } = string.Empty;
    }
}
