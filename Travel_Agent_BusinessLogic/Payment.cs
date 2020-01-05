using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Payment
    {
        private int paymentCode;
        private int vaucherID;
        private string dates;
        private int amount;
        
        
        public Payment(int vID, string date, int Amount)
        {

            this.vaucherID = vID;
            this.dates = date;
            this.amount = Amount;
            
        }

        public Payment(int PCode, int vID,  string date, int Amount)
        {
            this.paymentCode = PCode;
            this.vaucherID = vID;
            this.dates = date;
            this.amount = Amount;
        }

        public int PaymentCode
        {
            get { return this.paymentCode; }
        }

        public string VaucherID
        {
            get { return this.vaucherID.ToString(); }
            set { this.vaucherID = Convert.ToInt32(value); }
        }

        public string DATES
        {
            get { return this.dates.ToString(); }
            set { this.dates = value; }
        }

        public string Amount
        {
            get { return this.amount.ToString(); ; }
            set { this.amount = Convert.ToInt32(value); }
        }

    }
}
