using System.ComponentModel.DataAnnotations;

namespace UniversityPlatformApi.Data.Models
{
    public class User : EntityBase
    {
        public int UserId { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [Required]
        public string Username { get; set; }

        [MaxLength(250)]
        [Required]
        public string Email { get; set; }

        [MaxLength(250)]
        [Required]
        public string Password { get; set; }

        [MaxLength(250)]
        [Required]
        public string Address { get; set; }
        [Required]
        public int UniversityId { get; set; }
        public University University{ get; set; }
    }
}
