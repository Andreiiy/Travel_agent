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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "" || textBox2.Text.ToString() != "")
            {
                string log = textBox1.Text.ToString();
                int pass = int.Parse(textBox2.Text.ToString());
                int check = TurAgentBL.LogPases.CheckLogPas(log, pass);
                if (check == 0 || check == 1)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Enter Login and Password");
                }
                else if (check == 2)
                {
                    FormClient windUser = new FormClient(log,pass);
                    windUser.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter Login and Password");
            }
        }
    }
}
