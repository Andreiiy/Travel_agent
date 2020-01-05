using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  public  class Directions
    {
        public static string GetContinent(int id)
        {
            Direction OneContinent;
            DataSet ds = TurAgentDLL.Direction.GetContinent(id);
            DataRow dr = ds.Tables[0].Rows[0];
            OneContinent = new Direction(int.Parse(dr[0].ToString()), dr[1].ToString());
            return OneContinent.GetContinent;
        }

        public static int GetContinentID(string cont)
        {
            Direction OneContinent;
            DataSet ds = TurAgentDLL.Direction.GetContinent_ID(cont);
            DataRow dr = ds.Tables[0].Rows[0];
            OneContinent = new Direction(int.Parse(dr[0].ToString()), dr[1].ToString());
            return OneContinent.GetID;
        }
        
    }
}
