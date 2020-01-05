using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
    public class Client
    {
        /// <summary>
        /// הוספת לקחות לטבלת התלמידים
        /// </summary>
        /// <param name="cName"></param>
        /// <param Surname="cSurName"></param>

        public static void AddClient(string cName, string cSurName, string email, string cNumTD, string cCiti)
        {
            DataSet ds = OleDbHelper.fill("select * from Client", "Client");

            DataRow dr = ds.Tables["Client"].NewRow();
            dr["ClientName"] = cName;
            dr["ClientSurname"] = cSurName;
            dr["Email"] = email;
            dr["NumberTD"] = cNumTD;
            dr["City"] = cCiti;

            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["Client"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.update(ds, "select * from Client", "Client");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.fill("select * from Client", "Client");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="surname"></param>
        /// <returns>DataSet</returns>
        public static DataSet GetClientID(string surname)
        {

            return OleDbHelper.fill(string.Format("select * from Client where ClientSurname='{0}'", surname), "Client");
        }

        public static DataSet GetClientName(int clientID)
        {

            return OleDbHelper.fill("select * from Client where ClientID=" + clientID, "Client");
        }

        public static DataSet Getcount()
        {
            return OleDbHelper.fill("select count(*) from Client", "Client");
        }

        public static void Update<T>(int clienttID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.fill(string.Format("select * from Client where ClientID={0}", clienttID), "Client");
            if (ds.Tables["Client"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Client"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.update(ds, "select * from Client", "Client");
            }
        }
    }
}
