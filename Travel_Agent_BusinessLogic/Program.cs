using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurAgentDLL;

namespace TurAgentBL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tur> tur = Turs.GetAll_View();
            List<Voucher> vav = Vouchers.GetVouchers_Viev();
           // LogPas pas = LogPases.GetLogPas("aaaa", 3333);
            List<Client> list=new List<Client>();
                 list = Clients.GetClientNotTravel();
            // //     string resalt = list[1].GetFirstname;
            // //     Console.WriteLine(resalt);
            // //Clients.GetClientNotTravel();
            // //Console.WriteLine("=======================================");
            // //Clients.GetClientDiscount();
            // //Console.WriteLine("=======================================");
            // Clients.GetClientNotPay();
            //int dd = LogPases.CheckLogPas("baby", 1111);
            //if (dd == 0)
            //    Console.WriteLine("Eto noll");
            //else
            // 
            //List<Client> listCL = new List<Client>();
            //listCL = Clients.GetClientNotPay();
            //Console.WriteLine();
            //List<Payment> listCL = new List<Payment>();
            //listCL = Payments.GetAllPays();
            List<Tur> listCL = new List<Tur>();
           listCL = Turs.GetResult_Search(2,2);
            Console.WriteLine();

        }
    }
}
