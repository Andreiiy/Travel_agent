using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
   public class Turs
    {
        public static List<Tur> GetAllTurs()
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetAll();
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
        }

        public static void AddTur(int sesonID, int directionID, string turName, int turPrice, string turDescription)
        {
            TurAgentDLL.Tur.AddTur(sesonID, directionID, turName, turPrice, turDescription);
        }
        public static void UpdateTur<T>(int voucherID, T inform, int place)
        {
            TurAgentDLL.Tur.Update(voucherID, inform, place);
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <param name="turID"></param>
        /// <returns></returns>
        
    public static Tur GetTUR(int turID)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetTUR(turID);
            DataRow dr = ds.Tables["Tur"].Rows[0];
            OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());

            return OneTur;
        }

        public static List<Tur> GetSesonTUR(int sesID)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetSesonTUR(sesID);
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
           
        }

        public static List<Tur> GetDirectionTUR(int directID)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetDirectionTUR(directID);
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
            
        }

        public static int GetTur_ID(string turName)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetTur_ID(turName);
            DataRow dr = ds.Tables["Tur"].Rows[0];
            OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());

            return OneTur.TurID;
            
        }

        public static List<Tur> GetSesDirTur(int sesonid, int directid)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetSesDirTur(sesonid, directid);
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
            
        }
        public static List<Tur> GetAll_View()
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetAll_View();
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
        }

        public static List<Tur> GetResult_Search(int sesonID, int directionID)
        {
            Tur OneTur;
            DataSet ds = TurAgentDLL.Tur.GetResult_Search(sesonID, directionID);
            List<Tur> listCL = new List<Tur>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneTur = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                listCL.Add(OneTur);
            }
            return listCL;
        }


        public static Tur GetExpensive_tour(int sesonID)
        {
            Tur maxprise ;
            DataSet ds = TurAgentDLL.Tur.GetExpensive_tour(sesonID);
            DataRow dr = ds.Tables["Tur"].Rows[0];
            maxprise = new Tur(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                        
            return maxprise;

        }

    }
}
