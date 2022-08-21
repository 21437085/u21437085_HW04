using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437085_HW04.Models
{
    public abstract class Details
    {

        private string sName;
        private string sSurname;
        private string sEmail;


        public Details(string Name, string Surname, string Email)
        {
            sName = Name;
            sSurname = Surname;
            sEmail = Email;
        }

        public string nameS
        {
            get { return sName; }
            set { sName = value; }
        }

        public string surnameS
        {
            get { return sSurname; }
            set { sSurname = value; }
        }

        public string emailS
        {
            get { return sEmail; }
            set { sEmail = value; }
        }

        public virtual string DInfo() 
        {
            return sName + " " + sSurname + " with email address " + sEmail; 
        }

    }
}