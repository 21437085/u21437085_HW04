using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437085_HW04.Models
{
    public class MusicVM:Details
    {

        private int iQuantity;

        public MusicVM(string Name, string Surname, string Email, int Quantity) : base(Name, Surname, Email)
        {
            iQuantity = Quantity;
        }

        public int quantityI
        {
            get { return iQuantity; }
            set { iQuantity = value; }

        }

        public override string DInfo()
        {
            return base.DInfo() + " is purchasing " + this.iQuantity + " tickets";
        }

    }
}