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
    /// Логика взаимодействия для MainPageClient.xaml
    /// </summary>
    public partial class MainPageClient : Page
    {
        public MainPageClient()
        {
            InitializeComponent();
        }

        private void UsersPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.UserClientPage());
        }

        private void MyProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddEditPage((sender as Button).DataContext as User));
        }

        private void CurrencyPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.CourseCurrencyPage());
        }

        private void WalletPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
