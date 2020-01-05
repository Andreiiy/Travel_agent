using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Sesons
    {
        public static string GetSeson(int id)
        {
            Seson OneSeson;
            DataSet ds = TurAgentDLL.Sesons.GetSesonName(id);
            DataRow dr = ds.Tables[0].Rows[0];
            OneSeson = new Seson(int.Parse(dr[0].ToString()), dr[1].ToString());
            return OneSeson.SesonName;
        }

        public static int GetSesonID(string seson)
        {
            Seson Oneseson;
            DataSet ds = TurAgentDLL.Sesons.GetSeson_ID(seson);
            DataRow dr = ds.Tables[0].Rows[0];
            Oneseson = new Seson(int.Parse(dr[0].ToString()), dr[1].ToString());
            return Oneseson.SesonID;
        }
    }
}
