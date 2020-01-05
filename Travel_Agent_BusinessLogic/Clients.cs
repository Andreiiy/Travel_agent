using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using TurAgentDLL;

namespace TurAgentBL
{
   public class Clients
    {
     public    List<Client> listCL;

        public static List<Client> GetAllClient()
        {
            Client OneClient;
            DataSet ds = TurAgentDLL.Client.GetAll();
        List<Client> listCL =new List<Client>();
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                OneClient = new Client(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                listCL.Add(OneClient);
            }
            return listCL;
        }
               
        public static List<Client> GetClientNotTravel()
        {
            List<Client> listCL = new List<Client>();
            List<Client> notTrevel = new List<Client>();

            List<Voucher> vouchCL = new List<Voucher>();
            //Console.WriteLine(" Clients did not traveling:    ");
            //Console.WriteLine(" ");

            listCL = GetAllClient();
            foreach (Client dr in listCL)
            {
                DateTime year = DateTime.Now;
                int data=int.Parse( String.Format("{0: yyyy}", year));
                vouchCL = Vouchers.GetVoucherClientYear(dr.ID, data);
                if (vouchCL.Count == 0)
                {
                    notTrevel.Add(dr);
                    // Console.WriteLine(dr.GetFirstname +" "+ dr.GetLastname +" ClientID = "+dr.GetID);
                }
            }
            return notTrevel;
        }

        public static string GetClientDiscount(int clientid)
        {
            
            List<Voucher> vouchCL = new List<Voucher>();
            string disc="";
            
                vouchCL = Vouchers.GetClientVoucher(clientid);
                if (vouchCL.Count <= 1)
                {
                return " 5% ";
                }
            if (vouchCL.Count > 1 && vouchCL.Count <= 3)
            {
                return "  10% ";
                
            }
            if (vouchCL.Count > 3 && vouchCL.Count <= 5)
            {
                return  "  20% ";
            }
            if (vouchCL.Count > 5)
            {
                return  "  30% ";
            }
            return disc;
       }

        public static Client GetClientName(int clientID)
        {
            Client OneClient;
            DataSet ds = TurAgentDLL.Client.GetClientName(clientID);
            DataRow dr = ds.Tables["Client"].Rows[0];
            OneClient = new Client(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());

            return OneClient;
        }

        public static List<Client> GetClientNotPay()
        {
            
            List<Voucher> listV = new List<Voucher>();
            List<Client> notPay = new List<Client>();

            List<Payment> listP = new List<Payment>();

            //Console.WriteLine(" Clients did not pay a voucher:    ");
            //Console.WriteLine(" ");

            listV = Vouchers.GetAllVoucher();
            foreach (Voucher dr in listV)
            {
                listP = Payments.GetPayment(dr.VoucherID);
                if (listP.Count == 0)
                {
                    Client OneClient = GetClientName(Convert.ToInt32(dr.ClientID));
                    notPay.Add(OneClient);
                 }
            }
            return notPay;
        }

        public static void AddClient(string name, string surname, string telefon, string numberTD, string city)
        {
            TurAgentDLL.Client.AddClient(name, surname, telefon,  numberTD, city);
        }
        public static void UpdateClient(int clientID, string inform,int place)
        {
            TurAgentDLL.Client.Update(clientID, inform, place);
        }

        

    }
}
