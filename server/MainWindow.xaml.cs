using System;
using System.Net;
using System.Threading;
using System.Windows;
using System.Net.Sockets;

namespace server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Thread thread;
        class Server
        {
            IPAddress iP;
            int port;
            TcpListener listener;
            public Server(string ip, string port)
            {
                iP = IPAddress.Parse(ip);
                this.port = Convert.ToInt32(port);
                listener = new TcpListener(iP, this.port);
            }
            void UsersAdd()
            {
                
            }
            public void Run()
            {
                try
                {
                    listener.Start();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        class Listener
        {
            public Listener()
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServerStart(object sender, RoutedEventArgs e)
        {
            Server server = new Server(Ip.Text, Port.Text);
            thread = new Thread(server.Run);
            thread.Start();
        }
    }
}
