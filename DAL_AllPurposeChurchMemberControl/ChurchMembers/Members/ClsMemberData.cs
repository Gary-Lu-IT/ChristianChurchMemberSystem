namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Members
{
    /// <summary>會員資料</summary>
    public class ClsMemberData
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = string.Empty;
        public DateTime? Birthdate { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool Baptized { get; set; }
        public DateTime? BaptismDate { get; set; }
        public bool Transferred { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public int? FamilyId { get; set; } // 如果與 Family 關聯
        public string Notes { get; set; } = string.Empty;
    }
}
