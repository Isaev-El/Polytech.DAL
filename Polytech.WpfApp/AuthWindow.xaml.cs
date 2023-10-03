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
using Polytech.BLL.Model;
using Polytech.BLL;

namespace Polytech.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        ServiceClient service;
        private readonly string path = @"C:\Temp\Polytech.db";
        public AuthWindow()
        {
            service = new ServiceClient(path);
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            ClientDTO client = new ClientDTO();
            client.Email = tbxEmail.Text;
            client.Password = pwdPassword.Password;

            var result=service.AuthorizationClient(client);

            MainWindow main = new MainWindow();
            main.Show();

            this.Close();
        }
    }
}
