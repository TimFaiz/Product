using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Gotov.Models;

namespace Gotov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static RushanSkidkaEntities DB = new RushanSkidkaEntities();
        public static User LoggedUser;
    }
}
