using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;

namespace DAL_AllPurposeChurchMemberControl.ChurchMembers.Events
{
    /// <summary>活動設定ID封包</summary>
    public class ClsEventSettingIdPack : ClsIdPackBase
    {
    }
    /// <summary>活動設定資訊</summary>
    public class ClsEventSetting
    {
        public int? Id { get; set; }
        /// <summary>事件名稱</summary>
        public string EventName { get; set; } = string.Empty;
        /// <summary>頻率(Daily:每天;Weekly:每週;Monthly:每月;Yearly:每年;Once:僅一次)</summary>
        public string Frequency { get; set; } = string.Empty;
        /// <summary>事件日期</summary>
        public string EventDate { get; set; } = string.Empty;
        /// <summary>舉辦時間</summary>
        public string EventTime { get; set; } = string.Empty;
        /// <summary>事件地點</summary>
        public string EventLocation { get; set; } = string.Empty;
        /// <summary>講師</summary>
        public string Leader { get; set; } = string.Empty;
        /// <summary>頻率設定是否有效</summary>
        /// <returns></returns>
        public bool FrequencyIsValid()
        {
            return Frequency switch
            {
                "Daily" => true,
                "Weekly" => true,
                "Monthly" => true,
                "Yearly" => true,
                "Once" => true,
                _ => false,
            };
        }
    }
    /// <summary>依據活動設定安排單次活動</summary>
    public class ClsEventCreateParamBySetting : ClsEventSettingIdPack
    {
        /// <summary>起始日期時間</summary>
        public DateTime FromDateTime { get; set; }
        /// <summary>終點日期時間</summary>
        public DateTime ToDateTime { get; set; }
    }
    /// <summary>
    /// 單次活動資訊
    /// </summary>
    public class ClsEvents
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Frequency { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string Leader { get; set; }
    }
}