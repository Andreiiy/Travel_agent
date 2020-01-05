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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TurAgent_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonIN_Click(object sender, RoutedEventArgs e)
        {

            //if (textBoxLogin.Text.ToString() != "" && int.Parse(passwordBoxPass.Password.ToString()) != 0)
            //{
            //    string log = textBoxLogin.Text.ToString();
            //    int pass = int.Parse(passwordBoxPass.Password.ToString());
            //    int check = TurAgentBL.LogPases.CheckLogPas(log, pass);
            //    if (check == 0)
            //    {
            //        textBoxLogin.Text = "";
            //        passwordBoxPass.Clear();
            //        MessageBox.Show("Enter Login and Password");
            //    }

            //    else if(check == 1)
            //    {
            //      WindowWorker windWork = new WindowWorker();
            //      windWork.Show();
            //        this.Close();
            //    }
            //    else if (check == 2)
            //    {
            //        WindowUser windUser = new WindowUser();
            //        windUser.Show();
            //        this.Close();
            //    }
            //}
            //else
            //{

            // MessageBox.Show("Enter Login and Password");
            //}

                 WindowWorker windWork = new WindowWorker();

            windWork.Show();
            this.Close();
        }
    }
}
