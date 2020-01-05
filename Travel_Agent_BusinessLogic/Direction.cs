using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
 public   class Direction
    {
        private int directID; 
        private string continent; 
        


        public Direction(string contin)
        {
            this.continent = contin;
           
        }
        public Direction(int id, string contin)
        {
            this.directID = id;
            this.continent = contin;
            
        }
        public int GetID
        {
            get { return this.directID; }
        }
        public string GetContinent
        {
            get { return this.continent; }
            
        }
    }
}
