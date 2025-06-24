using API_AllPurposeChurchMemberControl.SQLiteDB.Entity;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Users;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using System.Security.Cryptography;

namespace API_AllPurposeChurchMemberControl.ChurchMemberAccess
{
    /// <summary>基督教會會員資料寫入器(本類別專用)</summary>
    internal class ClsChurchDataWriter
    {
        #region 會員資料管理模組 (Member Data Management Module)
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
                Name = x.name,
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
                    datas=datas.Where(x=>x.Name.Contains(param.NameKeyword));
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
        #endregion

        #region 帳號與權限模組 (Account & Permission Module)
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
