using System.ComponentModel.DataAnnotations;

namespace IMS_kien.models
{
    public class Users {
        [Key]
        public string idUser {get; set;}
        [Required]
        [StringLength(50)]
        public string nameUser {get; set;}
        [Required]
        [StringLength(50)]
        public string phoneNumber { get; set;}
        public byte gender { get; set; }
        public DateTime DoB { get; set; }
        [Required]
        [StringLength(50)]
        public string addR { get; set; }
        public DateTime dateCreate { get; set; } = DateTime.Now; 
        public DateTime dateEdit { get; set; } = DateTime.Now;
        [Required]
        [StringLength(50)]
        public string creator { get; set; }
        public string editor { get; set; }
        [Required]
        [StringLength(50)]
        public string account { get; set; }
        [Required]
        [StringLength(50)]
        public string pwd { get; set; }
        public byte isActive { get; set; }
        [Required]
        [StringLength(50)]
        public string idRole { get; set; }
    }
}
