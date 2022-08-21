using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437085_HW04.Models
{
    public class CannedVM:Details
    {
        private int iQuantity;

        public CannedVM(string Name, string Surname, string Email, int Quantity) : base(Name, Surname, Email)
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
            return base.DInfo()+" is donating "+this.iQuantity+" items";
        }

    }
}