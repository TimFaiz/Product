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
    /// Логика взаимодействия для BasketOrderPage.xaml
    /// </summary>
    public partial class BasketOrderPage : Page
    {
        public BasketOrderPage()
        {
            InitializeComponent();
            var orderProduct = App.DB.OrderProduct.Where(p => p.Order.IDUser == App.LoggedUser.ID);
            DGBasket.ItemsSource = orderProduct.ToList();
        }
    }
}
