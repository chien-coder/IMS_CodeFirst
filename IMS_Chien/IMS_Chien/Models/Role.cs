using System.ComponentModel.DataAnnotations;

namespace IMS_Chien.Models
{
    public class Role
    {
        [Key]
        public Guid idRole { get; set; }
        public string nameRole { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public DateTime? dateUpdated { get; set; } = DateTime.Now;
        public bool isActive { get; set; } = true;
        public Guid creator { get; set; }
        public Guid? editor { get; set; }
    }
}
