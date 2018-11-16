using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RandyPowell.Models
{
    public class Experience
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Dates { get; set; }

        public int Type { get; set; }
        public ICollection<ExperienceSkill> ExperienceSkills { get; set; }

        public string _desc { get; set; }
        
    }

}
    
