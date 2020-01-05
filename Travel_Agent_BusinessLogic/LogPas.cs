using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class LogPas
    {
        private int clientID;
        private int worker;
        private string login;
        private int password;


        public LogPas(int clientID, int worker, string login, int password)
        {

            this.clientID = clientID;
            this.worker = worker;
            this.login = login;
            this.password = password;


        }

        public LogPas()
        {
                        
        }

        public int GetClientID
        {
            get { return this.clientID; }
        }

        public string GetWorker
        {
            get { return this.worker.ToString(); }
            set { this.worker = Convert.ToInt32(value); }
        }

        public string GetLogin
        {
            get { return this.login.ToString(); }
            set { this.login = value; }
        }

        public string GetPassword
        {
            get { return this.password.ToString(); ; }
            set { this.password = Convert.ToInt32(value); }
        }
    }
}
