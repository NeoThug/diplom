using CryptoApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CryptoApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        //private static string _currentDirectory = Directory.GetCurrentDirectory() + @"\Photos\";

        public MainPage()
        {
            InitializeComponent();
            CbCountry.ItemsSource = CryptoWalletEntities.GetContext().Countries.ToList();
        }

        

        private void Contries_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
