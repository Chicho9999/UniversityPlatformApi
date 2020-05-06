﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPlatformApi.Models
{
    public class University
    {
        public int UniversityId { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }
    }
}