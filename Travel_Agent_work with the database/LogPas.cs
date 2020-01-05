using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
   public class LogPas
    {
        public static void AddLogPas(int clientID, int worker,string login,int password)
        {
            DataSet ds = OleDbHelper.fill("select * from LogPas", "LogPas");

            DataRow dr = ds.Tables["LogPas"].NewRow();
            dr["ClientID"] = clientID;
            dr["Worker"] = worker;
            dr["Login"] = login;
            dr["Password"] = password;
            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["LogPas"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.update(ds, "select * from LogPas", "LogPas");
        }

        public static void Update<T>(int clienttID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.fill(string.Format("select * from LogPas where ClientID={0}", clienttID), "LogPas");
            if (ds.Tables["LogPas"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["LogPas"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.update(ds, "select * from LogPas", "LogPas");
            }
        }

        public static DataSet GetLogPas(string login,int password)
        {

            return OleDbHelper.fill("select * from LogPas where Login='"+ login+"' and Password ="+ password , "LogPas");//
        }
    }
}
