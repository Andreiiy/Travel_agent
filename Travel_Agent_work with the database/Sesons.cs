using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
    public class Sesons
    {
        public static DataSet GetSesonName(int sesonID)
        {
            return OleDbHelper.fill("select * from Sesons where SesonID="+ sesonID, "Sesons");
        }

        public static DataSet GetSeson_ID(string seson)
        {
            return OleDbHelper.fill("select * from Sesons where SesonName='"+ seson+"'", "Sesons");
        }

    }
}
