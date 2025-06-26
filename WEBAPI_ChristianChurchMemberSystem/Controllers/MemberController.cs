using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Members;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_ChristianChurchMemberSystem.Controllers
{
    /// <summary>會員資料管理模組</summary>
    [ApiController]
    [Route("[controller]")]
    public class MemberController : Controller
    {
        /// <summary>新增會員資料：新增一個會員的基本資料。</summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult AddMember([FromBody] ClsMemberData data)
        {
            try
            {
                ClsChurchDataSaver.AddMember(data);
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
        /// <summary>更新會員資料：修改現有會員的各項基本資料。</summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]public IActionResult UpdateMember([FromBody] ClsMemberData data)
        {
            try
            {
                ClsChurchDataSaver.UpdateMember(data);
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
        /// <summary>取得會員清單：查詢所有會員或根據條件篩選會員清單。</summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetMemberList([FromQuery] ClsMemberQueryParam? param = null)
        {
            try
            {
                return Ok(ClsChurchDataSaver.GetMemberList(param));
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