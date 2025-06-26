namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Members
{
    /// <summary>ID封包</summary>
    public abstract class ClsIdPackBase
    {
        public int Id { get; set; }
    }
    /// <summary>會員ID封包</summary>
    public class ClsMemberIdPack : ClsIdPackBase
    {
    }
}
