using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgentBL
{
    public class Payments
    {
        public static List<Payment> GetPayment(int vouchID)
        {
            Payment OnePayment;
            DataSet ds = TurAgentDLL.Payment.GetPayment(vouchID);
            List<Payment> listPay = new List<Payment>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OnePayment = new Payment(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), dr[2].ToString(), int.Parse(dr[3].ToString()));
                listPay.Add(OnePayment);
            }
            return listPay;
        }


        public static List<Payment> GetAllPays()
        {
            Payment OnePay;
            DataSet ds = TurAgentDLL.Payment.GetAll();
            List<Payment> listCL = new List<Payment>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OnePay = new Payment(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), dr[2].ToString(), int.Parse(dr[3].ToString()));
                listCL.Add(OnePay);
            }
            return listCL;
        }

        public static void AddPayment(int voucherID, string data, int amount)
        {
            TurAgentDLL.Payment.AddPayment(voucherID, data, amount);
        }
        public static void UpdatePayment<T>(int voucherID, T inform, int place)
        {
            TurAgentDLL.Payment.Update(voucherID, inform, place);
        }
    }
}
