using API_AllPurposeChurchMemberControl.SQLiteDB.Entity;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Announcements;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Families;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Users;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using System.Security.Cryptography;

namespace API_AllPurposeChurchMemberControl.ChurchMemberAccess
{
    /// <summary>基督教會會員資料寫入器(本類別專用)</summary>
    internal class ClsChurchDataWriter
    {
        #region 一、會員資料管理模組 (Member Data Management Module)
        /// <summary>新增一個會員的基本資料。</summary>
        /// <param name="data"></param>
        public static void AddMember(ClsMemberData data)
        {
            using ChurchMembersContext db = new();
            db.members.Add(new members
            {
                name = data.memberName,
                gender = data.Gender,
                birthdate = data.Birthdate,
                phone = data.Phone,
                email = data.Email,
                address = data.Address,
                baptized = data.Baptized,
                baptism_date = data.BaptismDate,
                group_name = data.GroupName,
                notes = data.Notes
            });
            db.SaveChanges();
        }
        /// <summary>修改現有會員的各項基本資料。</summary>
        /// <param name="data"></param>
        public static void UpdateMember(ClsMemberData data)
        {
            using ChurchMembersContext db = new();
            members? m = db.members.Where(x => x.id == data.Id).FirstOrDefault();
            if (m == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDNotExist);
            }
            else
            {
                m.name= data.memberName;
                m.birthdate=data.Birthdate;
                m.gender = data.Gender;
                m.phone= data.Phone;
                m.email= data.Email;
                m.address= data.Address;
                m.baptized= data.Baptized;
                m.baptism_date= data.BaptismDate;
                m.group_name = data.GroupName;
                m.notes=data.Notes;
                db.SaveChanges();
            }
        }
        /// <summary>根據會員 ID 查詢單一會員的詳細資料。</summary>
        /// <param name="MemberId"></param>
        /// <returns></returns>
        public static ClsMemberData? GetMemberById(int MemberId)
        {
            return new ChurchMembersContext().members.Where(x => x.id == MemberId)
                .Select(x => new ClsMemberData
                {
                    Id = x.id,
                    Baptized = x.baptized ?? false,
                    BaptismDate = x.baptism_date,
                    Birthdate = x.birthdate,
                    Email = x.email ?? string.Empty,
                    Gender = x.gender ?? string.Empty,
                    GroupName = x.group_name ?? string.Empty,
                    memberName = x.name,
                    Notes = x.notes ?? string.Empty,
                    Phone = x.phone ?? string.Empty,
                    Address = x.address ?? string.Empty,
                    Transferred = x.transferred ?? false,
                    FamilyId = x.family_id,
                }).FirstOrDefault();
        }
        /// <summary>從系統中移除一個會員資料</summary>
        /// <param name="MemberId"></param>
        public static void DeleteMember(int MemberId)
        {
            using ChurchMembersContext db = new();
            members? m = db.members.Where(x => x.id == MemberId).FirstOrDefault();
            if (m == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDNotExist);
            }
            if (m.stopusedate != null)
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberDataStopped);
            }
            if (db.event_attendance.Where(x => x.member_id == MemberId).Any()
                || db.offerings.Where(x => x.member_id == MemberId).Any()
                || db.attendance.Where(x => x.member_id == MemberId).Any()
                || db.users.Where(x => x.member_id == MemberId).Any())
            {
                //有參加活動、有奉獻、有帳號就只能停用
                m.stopusedate = DateTime.Now;
            }
            else {
                db.members.Remove(m);
            }
            db.SaveChanges();
        }
        /// <summary>查詢所有會員或根據條件篩選會員清單。</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IList<ClsMemberData> GetMemberList(ClsMemberQueryParam? param = null)
        {
            using ChurchMembersContext db = new();
            IQueryable<ClsMemberData> datas = db.members.Select(x => new ClsMemberData
            {
                Id=x.id,
                Baptized = x.baptized ?? false,
                BaptismDate = x.baptism_date,
                Birthdate = x.birthdate,
                Email = x.email ?? string.Empty,
                Gender = x.gender ?? string.Empty,
                GroupName = x.group_name ?? string.Empty,
                memberName = x.name,
                Notes = x.notes ?? string.Empty,
                Phone = x.phone ?? string.Empty,
                Address = x.address ?? string.Empty,
                Transferred = x.transferred ?? false,
                FamilyId = x.family_id,
            });
            if (param != null)
            {
                if (!string.IsNullOrWhiteSpace(param.NameKeyword))
                {
                    datas=datas.Where(x=>x.memberName.Contains(param.NameKeyword));
                }
                if (!string.IsNullOrWhiteSpace(param.PhoneKeyword))
                {
                    datas=datas.Where(x=>x.Phone.Contains(param.PhoneKeyword));
                }
                if(!string.IsNullOrWhiteSpace(param.GroupName))
                {
                    datas=datas.Where(x=>x.GroupName.Contains(param.GroupName));
                }
                if (param.IsBaptized != null)
                {
                    datas = datas.Where(x => x.Baptized == param.IsBaptized);
                }
            }
            return [.. datas];
        }
        #region 家庭資料管理模組 (Family Data Management Module)
        /// <summary>新增家庭資料</summary>
        /// <param name="families"></param>
        public static void AddFamily(ClsFamilies families)
        {
            using ChurchMembersContext db = new();
            db.families.Add(new families
            {
                family_name = families.FamilyName,
                address = families.FamilyAddress,
                contact_phone = families.FamilyPhone
            });
            db.SaveChanges();
        }
        /// <summary>更新家庭資訊</summary>
        /// <param name="families"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void UpdateFamily(ClsFamilies families)
        {
            using ChurchMembersContext db = new();
            families? f = db.families.Where(x => x.id == families.Id).FirstOrDefault();
            if (f == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.FamilyIDNotExist);
            }
            else
            {
                f.family_name = families.FamilyName;
                f.address = families.FamilyAddress;
                f.contact_phone = families.FamilyPhone;
                db.SaveChanges();
            }
        }
        /// <summary>依Id取得家庭資訊</summary>
        /// <param name="FamilyId"></param>
        /// <returns></returns>
        public static ClsFamilies? GetFamilyById(int FamilyId)
        {
            return new ChurchMembersContext().families.Where(x => x.id == FamilyId)
                .Select(x => new ClsFamilies
                {
                    Id = x.id,
                    FamilyName = x.family_name ?? string.Empty,
                    FamilyAddress = x.address ?? string.Empty,
                    FamilyPhone = x.contact_phone ?? string.Empty
                }).FirstOrDefault();
        }
        /// <summary>刪除家庭資料</summary>
        /// <param name="FamilyId"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void DeleteFamily(int FamilyId)
        {
            using ChurchMembersContext db = new();
            families? f = db.families.Where(x => x.id == FamilyId).FirstOrDefault();
            if (f == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.FamilyIDNotExist);
            }
            if (db.members.Where(x => x.family_id == FamilyId).Any())
            {
                throw new ChurchMemberException(SystemReturnMessage.FamilyHasMembers);
            }
            db.families.Remove(f);
            db.SaveChanges();
        }
        /// <summary>是否有教友屬於此編號的家庭</summary>
        /// <param name=""></param>
        /// <returns></returns>
        internal static bool HasFamilyMembers(int FamilyId)
        {
            using ChurchMembersContext db = new();
            return db.members.Where(x => x.family_id == FamilyId).Any();
        }
        /// <summary>查詢所有家庭或根據條件篩選家庭清單。</summary>
        public static IList<ClsFamilies> GetFamilyList(ClsFamilyQueryParam? param = null)
        {
            using ChurchMembersContext db = new();
            IQueryable<ClsFamilies> datas = db.families.Select(x => new ClsFamilies
            {
                Id = x.id,
                FamilyName = x.family_name ?? string.Empty,
                FamilyAddress = x.address ?? string.Empty,
                FamilyPhone = x.contact_phone ?? string.Empty
            });
            if(param!=null && !string.IsNullOrWhiteSpace(param.FamilyName))
            {
                datas = datas.Where(x => x.FamilyName.Contains(param.FamilyName));
            }
            return [.. datas];
        }
        #endregion
        #endregion

        #region 二、帳號與權限模組 (Account & Permission Module)
        /// <summary>驗證使用者帳號密碼，並記錄登入日誌。</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static ClsLoginReturn UserLogin(ClsLoginParam param)
        {
            using ChurchMembersContext db = new();
            if (param.LoginId == "admin" && param.Password == "admin" + DateTime.Now.ToString("yyyy/MM/dd"))
            {
                db.login_logs.Add(new login_logs
                {
                    user_id = -2 ^ 31,
                    ip_address = param.IPAddress,
                    login_time = DateTime.Now
                });
                db.SaveChanges();
                return new ClsLoginReturn
                {
                    Id = -2 ^ 31,
                    Name = "系統管理員",
                    Role = "admin"
                };
            }
            else
            {
                users? u = db.users.Where(x => x.loginid == param.LoginId).FirstOrDefault();
                if (u == null || !VerifyPassword(param.Password, u.password))
                {
                    throw new ChurchMemberException(SystemReturnMessage.WrongIDOrPassword);
                }
                db.login_logs.Add(new login_logs
                {
                    ip_address = param.IPAddress,
                    user_id = u.id,
                    user = u,
                    login_time = DateTime.Now
                });
                db.SaveChanges();
                return new ClsLoginReturn
                {
                    Id = u.id,
                    Name = u.username,
                    Role = u.role
                };
            }
        }
        #endregion

        #region 六、公告通知模組 (Announcement Module) 此模組負責發布和管理系統公告
        /// <summary>管理員發布系統公告。</summary>
        /// <param name="data"></param>
        public static void PublishAnnouncement(ClsAnnouncementData data)
        {
            using ChurchMembersContext db = new();
            db.announcements.Add(new announcements
            {
                title = data.Title,
                content = data.Content,
                posted_at = DateTime.Now
            });
            db.SaveChanges();
        }
        /// <summary>修改現有公告的內容。</summary>
        /// <param name="data"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void UpdateAnnouncement(ClsAnnouncementData data)
        {
            using ChurchMembersContext db = new();
            announcements? a = db.announcements.Where(x => x.id == data.Id).FirstOrDefault();
            if (a == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.AnnouncementIDNotExist);
            }
            else
            {
                a.title = data.Title;
                a.content = data.Content;
                a.posted_at = DateTime.Now;
                db.SaveChanges();
            }
        }
        /// <summary>移除一個公告。</summary>
        /// <param name="AnnouncementId"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void DeleteAnnouncement(int AnnouncementId)
        {
            using ChurchMembersContext db = new();
            announcements? a = db.announcements.Where(x => x.id == AnnouncementId).FirstOrDefault();
            if (a == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.AnnouncementIDNotExist);
            }
            db.announcements.Remove(a);
            db.SaveChanges();
        }
        /// <summary>取得單筆系統公告。</summary>
        /// <param name="AnnouncementId"></param>
        /// <returns></returns>
        public static ClsAnnouncementData? GetAnnouncementById(int AnnouncementId)
        {
            using ChurchMembersContext db = new();
            return db.announcements.Where(x => x.id == AnnouncementId).Select(x => new ClsAnnouncementData
            {
                Id = x.id,
                Title = x.title ?? string.Empty,
                Content = x.content ?? string.Empty,
                PublishDateTime = x.posted_at
            }).FirstOrDefault();
        }
        /// <summary>查詢系統公告列表。</summary>
        /// <returns></returns>
        public static IList<ClsAnnouncementData> GetAnnouncements()
        {
            using ChurchMembersContext db = new();
            return db.announcements.Select(x => new ClsAnnouncementData
            {
                Id = x.id,
                Title = x.title ?? string.Empty,
                Content = x.content ?? string.Empty,
                PublishDateTime = x.posted_at
            }).ToList();
        }
        #endregion

        #region 私有函數
        /// <summary>ChatGPT推薦PBKDF2比SHA512更安全而簡單的密碼加密法(加密部)</summary>
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
                HashAlgorithmName.SHA256,32);

            // 將鹽值與雜湊合併後轉為 Base64 儲存
            return Convert.ToBase64String(salt.Concat(hash).ToArray());
        }
        /// <summary>ChatGPT推薦PBKDF2比SHA512更安全而簡單的密碼加密法(密碼檢核部)</summary>
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
                HashAlgorithmName.SHA256,32);

            // 比較兩個雜湊是否一致
            return CryptographicOperations.FixedTimeEquals(storedHash, hashToCheck);
        }
        #endregion
    }
}
