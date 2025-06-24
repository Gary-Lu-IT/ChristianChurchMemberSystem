namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Members
{
    /// <summary>會員資料</summary>
    public class ClsMemberData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Baptized { get; set; }
        public DateTime? BaptismDate { get; set; }
        public bool Transferred { get; set; }
        public string GroupName { get; set; }
        public int? FamilyId { get; set; } // 如果與 Family 關聯
        public string Notes { get; set; }
    }
}
