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
using WalletApp.Models;
using WalletApp.Windows;

namespace WalletApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<User>user = CryptoWalletEntities.GetContext().Users.ToList();
                User u = user.FirstOrDefault(p => p.Password == PbPass.Password && p.Login == TbLogin.Text);
                if (u != null)
                {
                    switch (u.ID_Role)
                    {
                        case 2: new MainWindow().ShowDialog();
                            break;
                        case 1:new Windows.AdminWindow().ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверные данные для входа");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }


        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.SignUpPage(null));
        }

        
    }
}
