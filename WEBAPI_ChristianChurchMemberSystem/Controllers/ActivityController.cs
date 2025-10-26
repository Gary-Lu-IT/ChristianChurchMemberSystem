using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Events;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_ChristianChurchMemberSystem.Controllers
{
    /// <summary>活動與課程控制器</summary>
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : Controller
    {
        #region 活動/課程基本資料
        /// <summary>新增定期活動/課程設定</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult AddRegularEventSetting([FromBody]ClsEventSetting events)
        {
            try
            {
                ClsChurchDataSaver.AddRegularEventSetting(events);
                return Ok(SystemReturnMessage.Success);
            }
            catch (ChurchMemberException ex)
            {
                ClsExceptionWriter.WriteError(ex.Message);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return Ok(ex.ErrorCode);
            }
            catch (Exception ex)
            {
                ClsExceptionWriter.WriteError(ref ex);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return StatusCode(500);
            }
        }
        /// <summary>修改定期活動/課程設定</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult UpdateRegularEventSetting([FromBody] ClsEventSetting events)
        {
            try
            {
                ClsChurchDataSaver.UpdateRegularEventSetting(events);
                return Ok(SystemReturnMessage.Success);
            }
            catch (ChurchMemberException ex)
            {
                ClsExceptionWriter.WriteError(ex.Message);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return Ok(ex.ErrorCode);
            }
            catch (Exception ex)
            {
                ClsExceptionWriter.WriteError(ref ex);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return StatusCode(500);
            }
        }
        /// <summary>刪除定期活動/課程設定</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult DeleteRegularEventSetting([FromBody] ClsEventSettingIdPack pack)
        {
            try
            {
                ClsChurchDataSaver.DeleteRegularEventSetting(pack.Id);
                return Ok(SystemReturnMessage.Success);
            }
            catch (ChurchMemberException ex)
            {
                ClsExceptionWriter.WriteError(ex.Message);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return Ok(ex.ErrorCode);
            }
            catch (Exception ex)
            {
                ClsExceptionWriter.WriteError(ref ex);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return StatusCode(500);
            }
        }
        /// <summary>取得所有定期活動/課程設定。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetRegularEventSettings()
        {
            try
            {
                var eventSettings = ClsChurchDataSaver.GetRegularEventSettings();
                return Ok(eventSettings);
            }
            catch (ChurchMemberException ex)
            {
                ClsExceptionWriter.WriteError(ex.Message);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return Ok(ex.ErrorCode);
            }
            catch (Exception ex)
            {
                ClsExceptionWriter.WriteError(ref ex);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return StatusCode(500);
            }
        }
        /// <summary>取得單筆定期活動/課程設定。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetAnnouncementById([FromBody] ClsEventSettingIdPack pack)
        {
            try
            {
                var eventData = ClsChurchDataSaver.GetRegularEventSettingById(pack.Id);
                return Ok(eventData);
            }
            catch (ChurchMemberException ex)
            {
                ClsExceptionWriter.WriteError(ex.Message);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return Ok(ex.ErrorCode);
            }
            catch (Exception ex)
            {
                ClsExceptionWriter.WriteError(ref ex);
                // 這裡可以加入日誌記錄或其他錯誤處理
                return StatusCode(500);
            }
        }
        #endregion

        #region 依據定期活動/課程安排行程
        #endregion

        #region 活動/課程報名與出席
        #endregion
    }
}
