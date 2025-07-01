using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;

namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Announcements
{
    /// <summary>公告ID封包</summary>
    public class ClsAnnouncementIdPack : ClsIdPackBase
    {
    }
    /// <summary>公告資訊</summary>
    public class ClsAnnouncementData
    {
        public int Id { get; set; } = -1;
        /// <summary>公告標題</summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>公告內容</summary>
        public string Content { get; set; } = string.Empty;
        /// <summary>公告發布日</summary>
        public DateTime? PublishDateTime { get; set; }
    }
}
