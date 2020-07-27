using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore1.Models
{
    public class UserSkills
    {
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
