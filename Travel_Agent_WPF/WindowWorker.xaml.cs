using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TurAgent_WPF
{
    /// <summary>
    /// Interaction logic for WindowWorker.xaml
    /// </summary>
    public partial class WindowWorker : Window
    {
        public WindowWorker()
        {
            InitializeComponent();
            Clients_View();
        }

        private void Clients_View()
        {
            List<TurAgentBL.Client> client = new List<TurAgentBL.Client>();
            List<TurAgentBL.Client> clientNotTrevel = new List<TurAgentBL.Client>();
            

            
            client = TurAgentBL.Clients.GetAllClient();
            clientNotTrevel = TurAgentBL.Clients.GetClientNotTravel();
            groupBox.Header = "Clients";
            groupBox1.Header = "Clients did not traveling:";
            dataGrid_Client.ItemsSource = client;
            dataGrid_ClientNotPay.ItemsSource = clientNotTrevel;
            
        }
        private void Payment_View()
        {
            
            List<TurAgentBL.Client> clientNotPay = new List<TurAgentBL.Client>();
            List<TurAgentBL.Payment> pay = new List<TurAgentBL.Payment>();

            pay = TurAgentBL.Payments.GetAllPays();
            
            clientNotPay = TurAgentBL.Clients.GetClientNotPay();
            groupBox.Header = "Vouchers and Payment";
            groupBox1.Header = "Clients did not pay:";
            dataGrid_Client.ItemsSource = pay;
            dataGrid_ClientNotPay.ItemsSource = clientNotPay;
            
        }

       
            private void Vouchers_View()
        {
            
            List<TurAgentBL.Client> clientNotTrevel = new List<TurAgentBL.Client>();
            List<TurAgentBL.Voucher> vouchers = new List<TurAgentBL.Voucher>();

            vouchers = TurAgentBL.Vouchers.GetVouchers_Viev();
            clientNotTrevel = TurAgentBL.Clients.GetClientNotTravel();
            groupBox.Header = "Clients";
            groupBox1.Header = "Clients did not traveling:";
            dataGrid_Client.ItemsSource = vouchers;
            dataGrid_ClientNotPay.ItemsSource = clientNotTrevel;
            
        }

        private void Turs_View()
        {

            List<TurAgentBL.Client> clientNotTrevel = new List<TurAgentBL.Client>();
            List<TurAgentBL.Tur> turs = new List<TurAgentBL.Tur>();

            turs = TurAgentBL.Turs.GetAll_View();
            clientNotTrevel = TurAgentBL.Clients.GetClientNotTravel();
            groupBox.Header = "Turs";
            groupBox1.Header = "Clients did not traveling:";
            dataGrid_Client.ItemsSource = turs;
            dataGrid_ClientNotPay.ItemsSource = clientNotTrevel;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           Clients_View();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            
            Payment_View();
        }

        private void btnVouchers_Click(object sender, RoutedEventArgs e)
        {
            Vouchers_View();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMessage_Click(object sender, RoutedEventArgs e)
        {

        }
               
        private void buttonAddPayment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonAddVoucher_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTurs_Click(object sender, RoutedEventArgs e)
        {
            Turs_View();
        }
    }
}
