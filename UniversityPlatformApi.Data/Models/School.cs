﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPlatformApi.Data.Models
{
    public class School
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
