using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Voucher
    {
        private int voucherID; 
        private string clientID; 
        private string sesonID;
        private string turID;
        private int years;
        



        public Voucher(string cID, string sID, string tID, int years)
        {
            
            this.clientID = cID;
            this.sesonID = sID;
            this.turID = tID;
            this.years = years;


        }
        public Voucher(int vID, string cID, string sID, string tID, int years)
        {
            this.voucherID = vID;
            this.clientID = cID;
            this.sesonID = sID;
            this.turID = tID;
            this.years = years;
        }

        public int VoucherID
        {
            get { return this.voucherID; }
        }

        public string ClientID
        {
            get { return  this.clientID.ToString(); }
            set { this.clientID = value; }
        }

        public string SesonID
        {
            get { return this.sesonID.ToString(); }
            set { this.sesonID =value; }
        }

        public string TurID
        {
            get { return this.turID.ToString(); ; }
            set { this.turID = value; }
        }

        public string Years
        {
            get { return this.years.ToString(); ; }
            set { this.years = Convert.ToInt32(value); }
        }
    }
}
