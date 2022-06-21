using System.ComponentModel.DataAnnotations;

namespace IMS_kien.models
{
    public class Projects
    {
        [Key]
        public string idProject { get; set; }
        [Required]
        [StringLength(50)]
        public string projectCode { get; set; }
        [Required]
        [StringLength(50)]
        public string projectName { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public bool isActive { get; set; } = true;
        [Required]
        [StringLength(50)]
        public string creator  { get; set; }
        public string idLeader { get; set; }
    }
}
