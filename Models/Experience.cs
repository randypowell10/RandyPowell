using System;
using System.Collections.Generic;
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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string[] Description { get; set; }
        public int Type { get; set; }

        public string GetDates() {

                return "September 2016 - December 2018";
        }
        
    }

}
    
