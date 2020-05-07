using System.ComponentModel.DataAnnotations;
namespace UniversityPlatformApi.Data.Models
{
    public class University : EntityBase
    {
        public int UniversityId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
    }
}
