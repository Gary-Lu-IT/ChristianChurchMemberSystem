using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Users;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using System.Security.Cryptography;

namespace API_AllPurposeChurchMemberControl.ChurchMemberAccess
{
    /// <summary>基督教會會員資料存取器(資料有效性檢查後叫Writer做)</summary>
    public class ClsChurchDataSaver
    {
        /*
         * C# 後端功能設計建議
以下為基督教會會員管理系統C#後端模組及其對應的功能 (function) 和參數建議：
一、會員資料管理模組 (Member Data Management Module) 此模組負責處理會員的基本資料、受洗狀況、家庭關係等。
•
資料表：members, families。
C# 方法簽名：
2.
更新會員資料 (UpdateMember)
◦
功能：用於修改現有會員的各項基本資料。
◦
C# 方法簽名：
3.
取得單一會員資料 (GetMemberById)
◦
功能：根據會員 ID 查詢單一會員的詳細資料。
◦
C# 方法簽名：
5.
刪除會員 (DeleteMember)
◦
功能：從系統中移除一個會員資料 [需要基於業務邏輯判斷是否允許物理刪除或僅標記為非活躍]。
◦
C# 方法簽名：
6.
管理家庭關係 (ManageFamilyRelation)
◦
功能：建立會員與家庭的關聯或更新家庭資訊。
◦
C# 方法簽名：
二、帳號與權限模組 (Account & Permission Module) 此模組負責系統的使用者登入、角色管理、權限控制、密碼重設等.
•
資料表：users, login_logs。
2.
變更使用者密碼 (ChangePassword)
◦
功能：使用者自行修改密碼。
◦
C# 方法簽名：
3.
重設使用者密碼 (ResetPassword)
◦
功能：管理員為指定使用者重設密碼。
◦
C# 方法簽名：
4.
建立使用者帳號 (CreateUserAccount)
◦
功能：新增系統使用者帳號，並設定角色與權限。
◦
C# 方法簽名：
5.
更新使用者角色/狀態 (UpdateUserAccount)
◦
功能：修改使用者帳號的角色或凍結狀態。
◦
C# 方法簽名：
6.
取得使用者權限 (GetUserPermissions)
◦
功能：根據使用者角色判斷其對應的功能存取權限。
◦
C# 方法簽名：
三、聚會出席模組 (Attendance Management Module) 此模組負責登錄、查詢和統計各類聚會的出席記錄。
•
資料表：attendance。
1.
登錄出席紀錄 (LogAttendance)
◦
功能：記錄會員某次聚會的出席狀態。
◦
C# 方法簽名：
2.
更新出席紀錄 (UpdateAttendance)
◦
功能：修改已登錄的出席記錄。
◦
C# 方法簽名：
3.
查詢會員出席歷史 (GetMemberAttendanceHistory)
◦
功能：查詢特定會員在一段時間內的出席記錄。
◦
C# 方法簽名：
4.
統計出席率 (CalculateAttendanceRate)
◦
功能：統計特定聚會類型或小組的出席率。
◦
C# 方法簽名：
5.
支援簽到 (ProcessCheckIn)
◦
功能：處理手動或 QR 碼簽到。
◦
C# 方法簽名：
四、奉獻管理模組 (Offering Management Module) 此模組負責登錄、查詢和統計會員的奉獻記錄，並生成收據。
•
資料表：offerings。
1.
登錄奉獻 (LogOffering)
◦
功能：記錄會員的單筆奉獻資料。
◦
C# 方法簽名：
2.
更新奉獻紀錄 (UpdateOffering)
◦
功能：修改已登錄的奉獻記錄。
◦
C# 方法簽名：
3.
查詢會員奉獻歷史 (GetMemberOfferingsHistory)
◦
功能：查詢特定會員在一段時間內的奉獻記錄。
◦
C# 方法簽名：
4.
產生奉獻收據 (GenerateOfferingReceipt)
◦
功能：為會員產生年度奉獻彙總收據。
◦
C# 方法簽名：
5.
統計奉獻總額 (CalculateTotalOfferings)
◦
功能：統計特定類別或時間範圍內的奉獻總額。
◦
C# 方法簽名：
五、活動與課程模組 (Activity & Course Module) 此模組負責建立活動/課程、管理報名與出席。
•
資料表：events, event_attendance。
1.
建立活動/課程 (CreateEvent)
◦
功能：新增一個活動或課程的基本資料。
◦
C# 方法簽名：
2.
更新活動/課程 (UpdateEvent)
◦
功能：修改活動或課程的詳細資料。
◦
C# 方法簽名：
3.
取得活動/課程列表 (GetEventList)
◦
功能：查詢所有活動或根據條件篩選活動清單。
◦
C# 方法簽名：
4.
報名活動/課程 (RegisterForEvent)
◦
功能：記錄會員報名參加活動/課程。
◦
C# 方法簽名：
5.
登錄活動出席 (LogEventAttendance)
◦
功能：記錄會員在特定活動中的出席狀態。
◦
C# 方法簽名：
6.
匯出報名與出席名單 (ExportEventParticipants)
◦
功能：匯出活動的報名人員或出席人員名單。
◦
C# 方法簽名：
六、公告通知模組 (Announcement Module) 此模組負責發布和管理系統公告。
•
資料表：announcements。
1.
發布公告 (PublishAnnouncement)
◦
功能：管理員發布系統公告。
◦
C# 方法簽名：
2.
更新公告 (UpdateAnnouncement)
◦
功能：修改現有公告的內容。
◦
C# 方法簽名：
3.
刪除公告 (DeleteAnnouncement)
◦
功能：移除一個公告。
◦
C# 方法簽名：
4.
取得公告列表 (GetAnnouncements)
◦
功能：查詢系統公告列表。
◦
C# 方法簽名：
七、查詢與統計報表模組 (Query & Report Module) 此模組提供多條件查詢和匯出各類報表的功能。
•
資料表：跨多個資料表查詢。
1.
匯出會員清單 (ExportMemberList)
◦
功能：根據指定條件匯出會員清單至 Excel 或 PDF。
◦
C# 方法簽名：
2.
匯出奉獻統計報表 (ExportOfferingReport)
◦
功能：匯出奉獻統計報表至 Excel 或 PDF。
◦
C# 方法簽名：
3.
匯出出席統計報表 (ExportAttendanceReport)
◦
功能：匯出出席統計報表至 Excel 或 PDF。
◦
C# 方法簽名：
4.
取得儀表板數據 (GetDashboardSummary)
◦
功能：提供系統首頁儀表板所需的會友數、出席率、今日活動等概覽數據。
◦
C# 方法簽名：
八、系統安全與備份模組 (System Security & Backup Module) 此模組處理登入記錄、資料備份與還原等功能。
•
資料表：login_logs。
1.
記錄登入日誌 (LogLoginAttempt)
◦
功能：記錄每次使用者登入的嘗試，無論成功或失敗。
◦
C# 方法簽名：
2.
執行資料備份 (PerformDataBackup)
◦
功能：執行資料庫的備份操作。
◦
C# 方法簽名：
3.
資料備份還原 (RestoreDataBackup)
◦
功能：從備份檔案還原資料庫。
◦
C# 方法簽名：
4.
匯出所有資料 (ExportAllSystemData)
◦
功能：允許管理員匯出所有系統資料 (例如：用於遷移或完整備份)。
◦
C# 方法簽名：
關於 DTO (Data Transfer Objects) 的說明： 在上述 C# 方法簽名中，我使用了 XXXDto 的命名方式。這代表您會需要設計對應的類別 (Class) 來封裝相關的資料欄位，作為方法的輸入或輸出。例如：
// 會員資料 DTO 範例
public class MemberDto
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

// 奉獻資料 DTO 範例
public class OfferingDto
{
    public int MemberId { get; set; }
    public DateTime OfferDate { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Remarks { get; set; }
}

// 查詢條件 DTO 範例
public class MemberQueryDto
{
    public string NameKeyword { get; set; }
    public string PhoneKeyword { get; set; }
    public string GroupName { get; set; }
    public bool? IsBaptized { get; set; }
    // 其他篩選條件
}
這些功能與參數設計是基於您提供的系統文件和資料庫架構進行的初步建議。在實際開發中，還需考慮錯誤處理、日誌記錄、非同步操作 (async/await)、資料驗證、以及更細緻的權限控制邏輯等。
         */
        #region 會員資料管理模組 (Member Data Management Module)
        /// <summary>新增一個會員的基本資料。</summary>
        /// <param name="data"></param>
        public static void AddMember(ClsMemberData data)
        {
            ClsChurchDataWriter.AddMember(data);
        }
        /// <summary>根據會員 ID 查詢單一會員的詳細資料。</summary>
        /// <param name="MemberId"></param>
        /// <returns></returns>
        public static ClsMemberData? GetMemberById(int MemberId)
        {
            ClsMemberData? md = ClsChurchDataWriter.GetMemberById(MemberId);
            return md;
        }
        /// <summary>取得會員清單：查詢所有會員或根據條件篩選會員清單。</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IList<ClsMemberData> GetMemberList(ClsMemberQueryParam? param = null)
        {
            return ClsChurchDataWriter.GetMemberList(param);
        }
        #endregion
        #region 帳號與權限模組 (Account & Permission Module)
        /// <summary>使用者登入：驗證使用者帳號密碼，並記錄登入日誌。</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static ClsLoginReturn UserLogin(ClsLoginParam param)
        {
            if(string.IsNullOrWhiteSpace(param.LoginId )||string.IsNullOrWhiteSpace(param.Password))
            {
                throw new ChurchMemberException(SystemReturnMessage.EmptyIDOrPassword);
            }
            return ClsChurchDataWriter.UserLogin(param);
        }
        #endregion

        #region 私有函數
        #region 密碼處理(PBKDF2)
        /// <summary>密碼加密</summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
            // 使用隨機產生的 16 byte 鹽值
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            // 使用 PBKDF2 產生 32 byte 密碼雜湊
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations: 100_000,  // 計算次數越高越安全
                HashAlgorithmName.SHA256, 32);

            // 將鹽值與雜湊合併後轉為 Base64 儲存
            return Convert.ToBase64String(salt.Concat(hash).ToArray());
        }
        /// <summary>密碼驗證</summary>
        /// <param name="password"></param>
        /// <param name="hashedPassword"></param>
        /// <returns></returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] decoded = Convert.FromBase64String(hashedPassword);
            byte[] salt = decoded.Take(16).ToArray();
            byte[] storedHash = decoded.Skip(16).ToArray();

            // 用相同鹽值與參數重新計算雜湊
            byte[] hashToCheck = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations: 100_000,
                HashAlgorithmName.SHA256,
                32);

            // 比較兩個雜湊是否一致
            return CryptographicOperations.FixedTimeEquals(storedHash, hashToCheck);
        }
        #endregion
        #endregion
    }
}
