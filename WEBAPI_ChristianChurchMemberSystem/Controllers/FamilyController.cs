using API_AllPurposeChurchMemberControl.ChurchMemberAccess;
using DAL_AllPurposeChurchMemberControl.ChurchMembers.Families;
using DAL_AllPurposeChurchMemberControl.ChurchSystem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_ChristianChurchMemberSystem.Controllers
{
    /// <summary>家庭資料管理模組</summary>
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : Controller
    {
        /// <summary>新增家庭資料：新增一個家庭的基本資料。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult AddFamily([FromBody] ClsFamilies families)
        {
            try
            {
                ClsChurchDataSaver.AddFamily(families);
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
        /// <summary>更新家庭資料：修改現有家庭的各項基本資料。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult UpdateFamily([FromBody] ClsFamilies families)
        {
            try
            {
                ClsChurchDataSaver.UpdateFamily(families);
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
        /// <summary>刪除家庭資料：刪除指定的家庭資料。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult DeleteFamily([FromBody] ClsFamilyIdPack familyIdPack)
        {
            try
            {
                ClsChurchDataSaver.DeleteFamily(familyIdPack.Id);
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
        /// <summary>查詢家庭資料：根據條件查詢家庭資料。</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetFamilyList([FromBody] ClsFamilyQueryParam queryParam)
        {
            try
            {
                var families = ClsChurchDataSaver.GetFamilyList(queryParam);
                return Ok(families);
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
        /// <summary>取得指定編號家庭資料</summary>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult GetFamilyById([FromBody] ClsFamilyIdPack familyIdPack)
        {
            try
            {
                var family = ClsChurchDataSaver.GetFamilyById(familyIdPack.Id);
                return Ok(family);
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
