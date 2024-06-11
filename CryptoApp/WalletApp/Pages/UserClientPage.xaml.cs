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
    /// Логика взаимодействия для UserClientPage.xaml
    /// </summary>
    public partial class UserClientPage : Page
    {
        public UserClientPage()
        {
            InitializeComponent();
            LWUsers.ItemsSource = CryptoWalletEntities.GetContext().Users.ToList();
        }
        private void Update()
        {
            var currentUsers = CryptoWalletEntities.GetContext().Users.OrderBy(p => p.ID_User).ToList();

            currentUsers = currentUsers.Where(p => p.NickName.ToLower().Contains(TbSearchNick.Text.ToLower())).ToList();

            //currentUsers = currentUsers.Where(p => p.Surname.ToLower().Contains(TbSearchSurname.Text.ToLower())).ToList();

            if (ComboPrice.SelectedIndex >= 0)
            {

                if (ComboPrice.SelectedIndex == 0)
                    currentUsers = currentUsers.OrderBy(p => p.Balance).ToList();

                if (ComboPrice.SelectedIndex == 1)
                    currentUsers = currentUsers.OrderByDescending(p => p.Balance).ToList();
            }
            LWUsers.ItemsSource = currentUsers;

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddEditPage((sender as Button).DataContext as User));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddEditPage(null));
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = LWUsers.SelectedItems.Cast<User>().ToList();

            if (MessageBox.Show($"вы точно хотите удалить этих {usersForRemoving.Count()} пользователей?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    CryptoWalletEntities.GetContext().Users.RemoveRange(usersForRemoving);
                    CryptoWalletEntities.GetContext().SaveChanges();
                    MessageBox.Show("Пользователи удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }



        private void TbSearchNick_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                LWUsers.ItemsSource = null;
            // загрузка обновленных данных
            CryptoWalletEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            List<User> users = CryptoWalletEntities.GetContext().Users.OrderBy(p => p.ID_User).ToList();
            LWUsers.ItemsSource = users;
        }

        private void ComboPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
