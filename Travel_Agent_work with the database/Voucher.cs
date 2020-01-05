using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
  public  class Voucher
    {
        public static void AddVoucher(int ClientID, int SesonID, int TurID, int Years)
        {
            DataSet ds = OleDbHelper.fill("select * from Voucher", "Voucher");

            DataRow dr = ds.Tables["Voucher"].NewRow();
            dr["ClientID"] = ClientID;
            dr["SesonID"] = SesonID;
            dr["TurID"] = TurID;
            dr["Years"] = Years;

            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["Voucher"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.update(ds, "select * from Voucher", "Voucher");
        }

        public static DataSet GetAll()
        {
            return OleDbHelper.fill("select * from Voucher", "Voucher");
        }

        public static DataSet GetAll_Viev()
        {
            return OleDbHelper.fill("select V.VoucherID, C.ClientSurname,S.SesonName,T.TurName,V.Years from Client C, Voucher V,Sesons S,Tur T where C.ClientID=V.ClientID and S.SesonID=V.SesonID and T.TurID=V.TurID", "Voucher");
        }

        public static DataSet Getcount()
        {
            return OleDbHelper.fill("select count(*) from Voucher", "Voucher");
        }
        
        public static DataSet GetClientVoucher(int idclient)
        {
            return OleDbHelper.fill("select * from Voucher where ClientID="+ idclient, "Voucher");
        }

        public static DataSet GetVoucherClientYear(int idclient,int year)
        {
            return OleDbHelper.fill("select * from Voucher where ClientID="+ idclient+ "and Years="+ year, "Voucher");
        }

        public static DataSet GetVoucherClientDirection(int idclient, int direction)
        {
            return OleDbHelper.fill("select * from Voucher where ClientID=" + idclient + "and Years=" + direction, "Voucher");
        }

        public static void Update<T>(int voucherID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.fill(string.Format("select * from Voucher where VoucherID={0}", voucherID), "Voucher");
            if (ds.Tables["Voucher"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Voucher"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.update(ds, "select * from Voucher", "Voucher");
            }
        }
    }
}
