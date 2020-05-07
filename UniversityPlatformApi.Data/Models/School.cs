using System.ComponentModel.DataAnnotations;

namespace UniversityPlatformApi.Data.Models
{
    public class School : EntityBase
    {
        public int SchoolId { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [MaxLength(250)]
        [Required]
        public string Address { get; set; }
        [Required]
        public int UniversityId { get; set; }
        public University University{ get; set; }
    }
}
