using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437085_HW04.Models
{
    public class SkillsVM:Details
    {

        private string sDescription;

        public SkillsVM(string Name, string Surname, string Email, string Description) : base(Name, Surname, Email)
        {
            sDescription = Description;
        }

        public string descriptionS
        {
            get { return sDescription; }
            set { sDescription = value; }

        }

        public override string DInfo()
        {
            return base.DInfo() + " has applied to offer skills involving: " + this.sDescription ;
        }

    }
}