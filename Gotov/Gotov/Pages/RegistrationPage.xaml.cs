using Gotov.Models;
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

namespace Gotov.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        User contextUser;
        public RegistrationPage(User user)
        {
            InitializeComponent();
            CBGender.ItemsSource = App.DB.Gender.ToList();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            var NewUser = App.DB.User.FirstOrDefault(p => p.Login == TBLogin.Text);
            if (string.IsNullOrWhiteSpace(TBFullName.Text) || string.IsNullOrWhiteSpace(TBEmail.Text) || CBGender.SelectedItem == null || string.IsNullOrWhiteSpace(TBLogin.Text) || string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (NewUser != null)
            {
                MessageBox.Show("Логин уже занят!");
                return;
            }
            contextUser.Roleid = 2;
            App.DB.User.Add(contextUser);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
