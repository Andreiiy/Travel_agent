using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
  
  public  class Vouchers
    {
        private List<Voucher> listVouch;
        
        public static List<Voucher> GetAllVoucher()
        {
            Voucher OneVoucher;
            DataSet ds = TurAgentDLL.Voucher.GetAll();
            List<Voucher> listCL = new List<Voucher>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneVoucher = new Voucher(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()));
                listCL.Add(OneVoucher);
            }
            return listCL;
        }

        public static List<Voucher> GetVouchers_Viev()
        {
            Voucher OneVoucher;
            DataSet ds = TurAgentDLL.Voucher.GetAll_Viev();
            List<Voucher> listCL = new List<Voucher>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneVoucher = new Voucher(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()));

                listCL.Add(OneVoucher);
            }
            return listCL;
        }

        public static List<Voucher> GetVoucherClientYear(int clID, int year)
            {
            Voucher OneVoucher;
            DataSet ds = TurAgentDLL.Voucher.GetVoucherClientYear(clID, year);
            List<Voucher> listVouch = new List<Voucher>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneVoucher = new Voucher(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()));

                listVouch.Add(OneVoucher);
            }
            return listVouch;
        }

        public static List<Voucher> GetClientVoucher(int idclient)
        {
            Voucher OneVoucher;
            DataSet ds = TurAgentDLL.Voucher.GetClientVoucher(idclient);
            List<Voucher> listVouch = new List<Voucher>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneVoucher = new Voucher(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()));

                listVouch.Add(OneVoucher);
            }
            return listVouch;
        }

        public static void AddVoucher(int clientID,int sesonID, int turID,int year)
        {
            TurAgentDLL.Voucher.AddVoucher(clientID, sesonID, turID, year);
        }
        public static void UpdateVoucher(int voucherID, string inform, int place)
        {
            TurAgentDLL.Voucher.Update(voucherID, inform, place);
        }
    }
}
