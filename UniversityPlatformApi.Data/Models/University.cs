using System.ComponentModel.DataAnnotations;
namespace UniversityPlatformApi.Data.Models
{
    public class University
    {
        public int UniversityId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
    }
}
