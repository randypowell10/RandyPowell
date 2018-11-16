using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandyPowell.Models;
namespace RandyPowell.Data
{
    public class DataInitial
    {
        private List<Skill> skills;
        private List<Experience> experiences;

        public DataInitial() {
            InitializeExperiences();
            InitializeSkills();
        }
        private void InitializeExperiences() {
            //initialize all experiences

        }
        private void InitializeSkills() {
            //initialize all skills

        }
        //public string[] GetExpSkills(int expID) {

        //    return [ "Asp.NET Core","Python"];
                
        //}
        //public Experience[] GetWorkExperiences() {


        //    return [""];
        //}
    }
}
