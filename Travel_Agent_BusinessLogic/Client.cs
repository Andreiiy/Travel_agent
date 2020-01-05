using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Client
    {
       

            private int clientID; //NUM
            private string firstname; //FName
            private string lastname; //LName
        private string email;
        private string numberTD;
        private string city;


        public Client(string name, string lastname, string email, string numberTD, string city)
            {
                this.firstname = name;
                this.lastname = lastname;
            this.email = email;
            this.numberTD = numberTD;
            this.city = city;

        }
        public Client(int id,string name, string lastname, string email, string numberTD, string city)
        {
            this.clientID = id;
            this.firstname = name;
            this.lastname = lastname;
            this.email = email;
            this.numberTD = numberTD;
            this.city = city;

        }
        public int ID
            {
                get { return this.clientID; }
            }
            public string Firstname
        {
                get { return this.firstname; }
                set { this.firstname = value; }
            }
            public string Lastname
            {
                get { return this.lastname; }
                set { this.lastname = value; }
            }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
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
