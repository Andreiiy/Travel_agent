using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Tur
    {
        private int turID; 
        private string sesonID; 
        private string directionID; 
        private string turName; 
        private int turPrice; 
        private string turDescription; 


        public Tur(  int turID,string sesonID,string directionID,string turName, int turPrice,string turDescription )
        {
            this.turID = turID;
            this.sesonID = sesonID;
            this.directionID = directionID;
            this.turName = turName;
            this.turPrice = turPrice;
            this.turDescription = turDescription;


        }
        
        public int TurID
        {
            get { return this.turID; }
        }
        public string SesonID
        {
            get { return this.sesonID.ToString(); }
            set { this.sesonID = value; }
        }
        public string DirectionID
        {
            get { return this.directionID.ToString(); }
            set { this.directionID = value; }
        }
        public string TurName
        {
            get { return this.turName; }
            set { this.turName = value; }
        }
        public string TurPrice
        {
            get { return this.turPrice.ToString(); }
            set { this.turPrice = Convert.ToInt32(value); }
        }
        public string TurDescription
        {
            get { return this.turDescription; }
            set { this.turDescription = value; }
        }
    }
}
