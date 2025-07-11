using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Announcements;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Families;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_ChristianChurchMemberSystem.Controllers
{
    /// <summary>公告管理控制器</summary>
    [ApiController][Route("[controller]")]public class AnnouncementController : Controller
    {
        /// <summary>發布公告：管理員發布系統公告。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult PublishAnnouncement([FromBody] ClsAnnouncementData data)
        {
            try
            {
                ClsChurchDataSaver.PublishAnnouncement(data);
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
        /// <summary>更新公告：修改現有公告的內容。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult UpdateAnnouncement([FromBody] ClsAnnouncementData data)
        {
            try
            {
                ClsChurchDataSaver.UpdateAnnouncement(data);
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
        /// <summary>刪除公告：移除一個公告。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult DeleteAnnouncement([FromBody] ClsAnnouncementIdPack pack)
        {
            try
            {
                ClsChurchDataSaver.DeleteAnnouncement(pack.Id);
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
        /// <summary>取得公告列表：查詢系統公告列表。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetAnnouncementList()
        {
            try
            {
                var announcementDatas = ClsChurchDataSaver.GetAnnouncements();
                return Ok(announcementDatas);
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
        /// <summary>取得單筆系統公告。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetAnnouncementById([FromBody] ClsAnnouncementIdPack pack)
        {
            try
            {
                var announcementData = ClsChurchDataSaver.GetAnnouncementById(pack.Id);
                return Ok(announcementData);
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
    }
}