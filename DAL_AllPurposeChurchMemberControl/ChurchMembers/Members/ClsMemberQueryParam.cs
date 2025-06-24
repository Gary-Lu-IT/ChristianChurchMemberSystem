namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Members
{
    /// <summary>會員資料查詢參數</summary>
    public class ClsMemberQueryParam
    {
        /// <summary>姓名關鍵字</summary>
        public string NameKeyword { get; set; }
        /// <summary>電話號碼關鍵字</summary>
        public string PhoneKeyword { get; set; }
        /// <summary>團契關鍵字</summary>
        public string GroupName { get; set; }
        /// <summary>是否受洗</summary>
        public bool? IsBaptized { get; set; }
    }
}
