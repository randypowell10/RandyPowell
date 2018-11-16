using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandyPowell.Models
{
    public class ExperienceSkill
    {
        public int ID { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
