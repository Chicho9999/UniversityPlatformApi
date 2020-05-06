using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPlatformApi.Models
{
    public class School
    {
        public int SchoolId { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        public int UniversityId { get; set; }
        public University University{ get; set; }
    }
}
