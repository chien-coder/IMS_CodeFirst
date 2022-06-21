using System.ComponentModel.DataAnnotations;

namespace MemberProjects_API.Dtos
{
    public class CreateMemberProjectDtos
    {
        public bool isView { get; set; }
        public bool isUpdate { get; set; }
        public bool isAdd { get; set; }
        public bool isDelete { get; set; }
        [Required]
        public Guid IdProject { get; set; }
        [Required]
        public Guid IdUser { get; set; }
    }
}
