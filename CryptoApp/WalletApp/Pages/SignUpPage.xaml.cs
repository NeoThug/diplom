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

namespace WalletApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        private User _currentUser = new User();

        public SignUpPage(User selectedUser)
        {
            InitializeComponent();
            if (selectedUser != null)
            {
                _currentUser = selectedUser;
            }
            DataContext = _currentUser;

            CbCountry.ItemsSource = CryptoWalletEntities.GetContext().Countries.ToList();
            CbSex.ItemsSource = CryptoWalletEntities.GetContext().Sexes.ToList();
            CbRole.ItemsSource = CryptoWalletEntities.GetContext().Roles.ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentUser.NickName == null)
                errors.AppendLine("Необходимо придумать ник");
            if (_currentUser.Login == null)
                errors.AppendLine("Необходимо придумать логин");
            if (_currentUser.Password == null)
                errors.AppendLine("Необходимо придумать пароль");
            if (_currentUser.PhoneNumber == null)
                errors.AppendLine("Необходимо указать номер телефона");
            if (_currentUser.Email == null)
                errors.AppendLine("Необходимо указать почту");
            if (_currentUser.Sex == null)
                errors.AppendLine("Необходимо указать пол");
            if (_currentUser.Country == null)
                errors.AppendLine("Необходимо указать страну");
            if (_currentUser.Role == null)
                errors.AppendLine("Необходимо указать роль");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentUser.ID_User == 0)
            {
                CryptoWalletEntities.GetContext().Users.Add(_currentUser);
            }
            try
            {
                CryptoWalletEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
