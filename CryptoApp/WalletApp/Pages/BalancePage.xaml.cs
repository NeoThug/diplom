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
    /// Логика взаимодействия для BalancePage.xaml
    /// </summary>
    public partial class BalancePage : Page
    {
        private User _currentUser = new User();
        public BalancePage(User selectedUser)
        {
            InitializeComponent();
            if (selectedUser != null)
            {
                _currentUser = selectedUser;
            }
            DataContext = _currentUser;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //StringBuilder errors = new StringBuilder();

            //if (_currentUser.Balance != null)
                //errors.AppendLine("Введите баланс");
            //if (_currentUser.Currency != null)
                //errors.AppendLine("Выберите валюту");

            //if (errors.Length > 0)
            //{
                //MessageBox.Show(errors.ToString());
                //return;
            //}
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        

    }
}
