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
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        Order contextOrder = new Order() { User = App.LoggedUser, Date = DateTime.Now };
        List<OrderProduct> orderProducts = new List<OrderProduct>();
        public ListPage()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            LVProduct.ItemsSource = App.DB.Product.ToList();
            DGBasket.ItemsSource = orderProducts.ToList();
        }
        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewProductPage(new Models.Product()));
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = LVProduct.SelectedItem as Models.Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Выберите продукт!");
                return;
            }
            NavigationService.Navigate(new NewProductPage(selectedProduct));
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = LVProduct.SelectedItem as Models.Product;
            if(selectedProduct == null)
            {
                MessageBox.Show("Выберите продукт!");
                return;
            }
            App.DB.Product.Remove(selectedProduct);
            App.DB.SaveChanges();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BBasketAdd_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = LVProduct.SelectedItem as Models.Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Выберите продукт!");
                return;
            }
            orderProducts.Add(new OrderProduct() { Order = contextOrder, Product = selectedProduct });
            Refresh();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if(orderProducts.Count == 0)
            {
                MessageBox.Show("Корзина пуста :(");
                return;
            }
            App.DB.Order.Add(contextOrder);
            App.DB.OrderProduct.AddRange(orderProducts);
            App.DB.SaveChanges();
            MessageBox.Show("Корзина успешно сохранена!)");
        }

        private void BDeleteBasket_Click(object sender, RoutedEventArgs e)
        {
            var deleteProduct = DGBasket.SelectedItem as OrderProduct;
            if(deleteProduct == null)
            {
                MessageBox.Show("Выберите продукт");
                return;
            }
            orderProducts.Remove(deleteProduct);
            Refresh();

        }
    }
}
