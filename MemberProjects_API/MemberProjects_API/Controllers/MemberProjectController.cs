using MemberProjects_API.Dtos;
using MemberProjects_API.Models;
using MemberProjects_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MemberProjects_API.Controllers
{
    [ApiController]

    public class MemberProjectController : Controller
    {
        private readonly IMemberProjectsManager _memberProjectsManager;
        private readonly ILogger<MemberProjectController> _logger;

        public MemberProjectController(IMemberProjectsManager memberProjectsManager, ILogger<MemberProjectController> logger)
        {
            _memberProjectsManager = memberProjectsManager;
            _logger = logger;
        }

        //GET: get all 
        [HttpGet("MemberProject/get-all-MemberProject")]
        public async Task<IActionResult> GetAllMemberProjectsAsnc()
        {
            try
            {
                return Ok(await _memberProjectsManager.GetAllMemberProjectsAsync());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return StatusCode(500);
            }
        }

        //GET: get member project by id 
        [HttpGet("MemberProject/get-MemberProject-by-id/{id}")]
        public async Task<IActionResult> GetMemberProjectByIdAsnc(string id)
        {
            try
            {
                var memberProDb = await _memberProjectsManager.GetMemberProjectsByIdAsync(id);
                if (memberProDb is null) return BadRequest();
                return Ok(memberProDb);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return StatusCode(500);
            }
        }

        //POST: add new member project
        [HttpPost("MemberProject/add-MemberProject/")]
        public async Task<IActionResult> GetMemberProjectByIdAsnc(CreateMemberProjectDtos createMemberProjectDtos)
        {
            try
            {
                var newMemberPro = new MemberProjects
                {
                    Id = Guid.NewGuid(),
                    isView = createMemberProjectDtos.isView,
                    isAdd = createMemberProjectDtos.isAdd,
                    isUpdate = createMemberProjectDtos.isUpdate,
                    isDelete = createMemberProjectDtos.isDelete,
                    IdProject = createMemberProjectDtos.IdProject,
                    IdUser = createMemberProjectDtos.IdUser
                    
                };
                await _memberProjectsManager.AddMemberProjectsAsync(newMemberPro);
                return Ok(newMemberPro);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException);
                return StatusCode(500);
            }
        }
    }
}
