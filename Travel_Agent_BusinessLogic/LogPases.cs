using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
   public class LogPases
    {
        public static int CheckLogPas(string login,int pass)
        {
            LogPas OnePassword;
            DataSet ds = TurAgentDLL.LogPas.GetLogPas(login,pass);
            if (ds.Tables[0].Rows.Count==0)
                return 0;
            else
            {
            DataRow dr = ds.Tables["LogPas"].Rows[0];
            OnePassword = new LogPas(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), dr[2].ToString(), int.Parse(dr[3].ToString()));
                if (int.Parse(OnePassword.GetWorker) == 1)
                    return 1;
                else
                    return 2;

            }

        }

        public static LogPas GetLogPas(string login, int password)
        {
            LogPas OnePassword;
            DataSet ds = TurAgentDLL.LogPas.GetLogPas(login, password);
            DataRow dr = ds.Tables["LogPas"].Rows[0];
            OnePassword = new LogPas(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), dr[2].ToString(), int.Parse(dr[3].ToString()));
            return OnePassword;
        }



        public static void AddLogPas(int clientID,int worker, string login,int password)
        {
            TurAgentDLL.LogPas.AddLogPas(clientID, worker, login, password);
        }
        public static void UpdateClient<T>(int clientID, T inform, int place)
        {
            TurAgentDLL.LogPas.Update(clientID, inform, place);
        }
    }
}
