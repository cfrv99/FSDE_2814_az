﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore1.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<UserSkills> UserSkills { get; set; }
    }
}
