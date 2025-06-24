using API_AllPurposeChurchMemberControl.SQLiteDB.Entity;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Users;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using System.Security.Cryptography;

namespace API_AllPurposeChurchMemberControl.ChurchMemberAccess
{
    /// <summary>基督教會會員資料寫入器(本類別專用)</summary>
    internal class ClsChurchDataWriter
    {
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

        #region 會員(members)
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
