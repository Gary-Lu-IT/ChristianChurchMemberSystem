using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;

namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Family
{
    public class ClsFamilyIdPack:ClsIdPackBase
    {
    }
    /// <summary>家庭資訊</summary>
    public class ClsFamilies
    {
        public int? Id { get; set; }
        /// <summary>名稱</summary>
        public string FamilyName { get; set; }=string.Empty;
        /// <summary>地址</summary>
        public string FamilyAddress { get; set; } = string.Empty;
        /// <summary>電話號碼</summary>
        public string FamilyPhone { get; set; } = string.Empty;
    }
    /// <summary>家庭資料查詢</summary>
    public class ClsFamilyQueryParam
    {
        /// <summary>名稱</summary>
        public string FamilyName { get; set; } = string.Empty;
    }
}
