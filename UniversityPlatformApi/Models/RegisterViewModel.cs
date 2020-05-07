using System.ComponentModel.DataAnnotations;

namespace UniversityPlatformApi.Controllers
{
    public class RegisterViewModel
    {
        [MaxLength(250)]
        [Required]
        public string Username { get; set; }

        [MaxLength(250)]
        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }
        [MaxLength(250)]
        [Required]
        public string LastName { get; set; }


        [MaxLength(250)]
        [Required]
        public string Email { get; set; }

        [MaxLength(250)]
        [Required]
        public string Address { get; set; }
        [Required]
        public int UniversityId { get; set; }
    }
}