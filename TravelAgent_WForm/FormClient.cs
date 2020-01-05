using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurAgent_Form
{
    public partial class FormClient : Form
    {
        private string login;
        private int password;
        public FormClient(string login, int password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }
        

        private void FormClient_Load(object sender, EventArgs e)
        {
            
            Search((TurAgentBL.Sesons.GetSesonID(comboBox1.Text)), TurAgentBL.Directions.GetContinentID(comboBox2.Text));
            Titlle(this.login, this.password);

        }

        private void Search(int ses,int dir )
        {
            List<TurAgentBL.Tur> tur = new List<TurAgentBL.Tur>();
            tur = TurAgentBL.Turs.GetResult_Search(ses, dir);
            dataGridView1.DataSource = tur;
        }

        public void Titlle(string login, int password)
        {
            TurAgentBL.LogPas wonClient;
            TurAgentBL.Client client;
            TurAgentBL.Tur tur;


            wonClient = TurAgentBL.LogPases.GetLogPas(login, password);
            client = TurAgentBL.Clients.GetClientName(wonClient.GetClientID);
            int season=0;
            DateTime month = DateTime.Now;
            string ggg = String.Format("{0:MM}", month);
            int data = int.Parse(ggg);
            if (data < 3 || data == 12)
                season = 1;
            else if(data >= 3 && data <= 5)
                season = 2;
            else if (data >= 6 && data <= 8)
                season = 3;
            else if (data >= 9 && data <= 11)
                season = 4;

            tur = TurAgentBL.Turs.GetExpensive_tour(season);
            lebTitle.Text = "Hello " + client.Firstname;
            labelS.Text = tur.TurName;
            labelDiskript.Text = tur.TurDescription;
            labelamount.Text = tur.TurPrice;
            labelDiskaunt.Text = TurAgentBL.Clients.GetClientDiscount(wonClient.GetClientID);
        }

        public void Set_log_pass(string login, int password)
        {
            this.login = login;
            this.password = password;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search((TurAgentBL.Sesons.GetSesonID(comboBox1.Text)), TurAgentBL.Directions.GetContinentID(comboBox2.Text));

        }

        private void buttonBaynow_Click(object sender, EventArgs e)
        {

        }
    }
}
