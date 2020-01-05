using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
   public class Client_Informs
    {
       

        //public static List<Client_Info> GetAllClient_Inf()
        //{
        //    Client_Info OneClientINF;
        //    DataSet ds = TurAgentDLL.Client_Inform.GetAll();
        //    List<Client_Info> listCL = new List<Client_Info>();

        //    foreach (DataRow dr in ds.Tables[0].Rows)
        //    {
        //        OneClientINF = new Client_Info(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
        //        listCL.Add(OneClientINF);
        //    }
        //    return listCL;
        //}

        //public static void AddClient_Inform(int clientID,string telefon, string numberTD, string city)
        //{
        //    TurAgentDLL.Client_Inform.AddClient_Inform(clientID,telefon, numberTD, city);
        //}

        //public static void UpdateClient_Inform<T>(int clientID, T inform, int place)
        //{
        //    TurAgentDLL.Client_Inform.Update(clientID, inform, place);
        //}

        //public static Client_Info GetClient_Inform(int clientID)
        //{
        //    Client_Info OneClientINF;
        //    DataSet ds = TurAgentDLL.Client_Inform.GetClient_Inform(clientID);
        //    DataRow dr = ds.Tables["Client_Inform"].Rows[0];
        //    OneClientINF = new Client_Info(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
        //    return OneClientINF;
            
        //}
    }
}
