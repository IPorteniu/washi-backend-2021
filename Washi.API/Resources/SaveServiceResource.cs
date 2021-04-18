﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Washi.API.Resources
{
    public class SaveServiceResource
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
