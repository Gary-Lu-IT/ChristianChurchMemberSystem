using API_AllPurposeChurchMemberControl.SQLiteDB.ExceptionLogs;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace API_AllPurposeChurchMemberControl.ChurchMemberAccess
{
    /// <summary>例外狀況事件紀錄器</summary>
    public class ClsExceptionWriter
    {
        /// <summary>記錄錯誤訊息</summary>
        /// <param name="message">文字錯誤訊息</param>
        public static void WriteError(string message)
        {
            MethodBase? CallerOfThisFunc = new StackTrace().GetFrame(0).GetMethod();
            using ExceptionLogContext elc = new();
            int iMax = !elc.EXCEPTIONDATA.Any() ? (-2 ^ 31) : elc.EXCEPTIONDATA.Max(x => x.SERIAL) + 1;
            elc.EXCEPTIONDATA.Add(new EXCEPTIONDATA
            {
                SERIAL = iMax,
                EVENTTIME = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fffffff"),
                EXMESSAGE = message,
                EXSTACKTRACE = string.Empty,
                CALLERFUNCTION = CallerOfThisFunc.Name,
                PARAM = JsonSerializer.Serialize(CallerOfThisFunc.GetParameters())
            });
            elc.SaveChanges();
        }
        /// <summary>記錄錯誤訊息</summary>
        /// <param name="exception">已發生例外狀況</param>
        public static void WriteError(ref Exception exception)
        {
            MethodBase? CallerOfThisFunc = new StackTrace().GetFrame(0).GetMethod();
            using ExceptionLogContext elc = new();
            int iMax = elc.EXCEPTIONDATA.Any() ? elc.EXCEPTIONDATA.Max(x => x.SERIAL) + 1 : (-2 ^ 31);
            elc.EXCEPTIONDATA.Add(new EXCEPTIONDATA
            {
                SERIAL = iMax,
                EVENTTIME = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fffffff"),
                EXMESSAGE = exception.Message,
                EXSTACKTRACE = exception.StackTrace ?? string.Empty,
                CALLERFUNCTION = CallerOfThisFunc.Name,
                PARAM = JsonSerializer.Serialize(CallerOfThisFunc.GetParameters())
            });
            elc.SaveChanges();
        }
    }
}
