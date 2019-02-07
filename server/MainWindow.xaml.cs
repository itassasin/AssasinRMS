using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Server
        {
            public Server(string ip, string port)
            {

            }
            void UsersAdd()
            {
                
            }
            public void Run()
            {

            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServerStart(object sender, RoutedEventArgs e)
        {
            Server server = new Server(Ip.Text, Port.Text);
            Thread thread = new Thread(server.Run);
            thread.Start();
        }
    }
}
