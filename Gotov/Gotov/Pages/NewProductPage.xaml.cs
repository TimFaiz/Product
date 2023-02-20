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
    /// Логика взаимодействия для NewProductPage.xaml
    /// </summary>
    public partial class NewProductPage : Page
    {
        Product contexProduct;
        public NewProductPage(Product product)
        {
            InitializeComponent();
            contexProduct = product;
            DataContext = contexProduct;
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBPrice.Text) || string.IsNullOrWhiteSpace(TBSale.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(contexProduct.ID == 0)
                App.DB.Product.Add(contexProduct);
            App.DB.SaveChanges();
            NavigationService.GoBack();

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
