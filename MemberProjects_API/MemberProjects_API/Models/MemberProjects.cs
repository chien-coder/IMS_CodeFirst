namespace MemberProjects_API.Models
{
    public class MemberProjects
    {
        public Guid Id { get; set; }
        public bool isActive { get; set; }
        public bool isView { get; set; }
        public bool isUpdate { get; set; }  
        public bool isAdd { get; set; }
        public bool isDelete { get; set; }
        public Guid IdProject { get; set; }
        public Guid IdUser { get; set; }
    }


}
