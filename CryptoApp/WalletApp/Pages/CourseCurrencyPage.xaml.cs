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
    /// Логика взаимодействия для CourseCurrencyPage.xaml
    /// </summary>
    public partial class CourseCurrencyPage : Page
    {
        public CourseCurrencyPage()
        {
            InitializeComponent();
            DGCurrency.ItemsSource = CryptoWalletEntities.GetContext().Currencies.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
