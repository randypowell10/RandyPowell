using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandyPowell.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public ICollection<ExperienceSkill> ExperienceSkills { get; set; }

    }
}
