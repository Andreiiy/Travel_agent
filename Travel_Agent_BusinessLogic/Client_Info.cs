using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
   public class Client_Info
    {
        private int clientID; 
        private string telefon;
        private string numberTD; 
        private string city; 



        public Client_Info(int clientID,string telefon, string numberTD, string city)
        {
            this.clientID = clientID;
            this.telefon = telefon;
            this.numberTD = numberTD;
            this.city = city;

        }
        
        public int ClientID
        {
            get { return this.clientID; }
        }
        public string Telefon
        {
            get { return this.telefon; }
            set { this.telefon = value; }
        }
        public string NumberTD
        {
            get { return this.numberTD; }
            set { this.numberTD = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
    }
}
