using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Seson
    {
        private int sesonID; 
        private string sesonName; 
       

        public Seson(int sesonID, string sesonName)
        {
            this.sesonID = sesonID;
            this.sesonName = sesonName;
        }
            

       
        public int SesonID
        {
            get { return this.sesonID; }
        }
        public string SesonName
        {
            get { return this.sesonName; }
            set { this.sesonName = value; }
        }
        
    }
}
