using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IChannelFactory.Factory;
using IChannelFactory.Interfaces;
using IChannelFactory.Model;

namespace GUI.BillEasy.Views.UserOriented
{
    /// <summary>
    /// Interaction logic for LoginSplash.xaml
    /// </summary>
    public partial class LoginSplash : Window
    {
        public LoginSplash()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ILogin login = new LoginFactory();
            User user = new User()
            {
                Username = txtUsername.Text,
                Password = pwdPassword.Password
            };
            var res = login.ValidateUser(user);
            if (res.IsSucess)
            {
                var mainWindow = new HomeMenu.HomeWindow();
                mainWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show(res.ResponseData);
            }

        }
    }
}
