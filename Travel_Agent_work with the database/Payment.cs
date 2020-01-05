using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentDLL
{
    public class Payment
    {
        public static void AddPayment( int VaucherID, string DATES, int Amount)
        {
            DataSet ds = OleDbHelper.fill("select * from Payment", "Payment");

            DataRow dr = ds.Tables["Payment"].NewRow();
            dr["VoucherID"] = VaucherID;
            dr["DATES"] = DATES;
            dr["Amount"] = Amount;

            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["Payment"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.update(ds, "select * from Payment", "Payment");
        }
                
        public static DataSet GetAll()
        {
            return OleDbHelper.fill("select * from Payment", "Payment");
        }

        public static DataSet GetPayment(int voucherID)
        {
            return OleDbHelper.fill(string.Format("select * from Payment where VoucherID= {0}", voucherID), "Payment");
        }

        public static void Update<T>(int paymentCode, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.fill(string.Format("select * from Payment where PaymentCode={0}", paymentCode), "Payment");
            if (ds.Tables["Payment"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Payment"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.update(ds, "select * from Payment", "Payment");
            }
        }
    }
}
