using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
    public class Direction
    {
        public static DataSet GetContinent(int directID)
        {
            return OleDbHelper.fill(string.Format("select * from Direction where DirectionID={0}", directID), "Direction");
        }

        public static DataSet GetContinent_ID(string cont)
        {
            return OleDbHelper.fill("select * from Direction where Continent='"+cont+"'", "Direction");
        }
    }
}
