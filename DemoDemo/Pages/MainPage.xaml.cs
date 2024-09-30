using DemoDemo.DB;
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

namespace DemoDemo.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static List<Service> discounts = DBConnection.dbe.Service.ToList();
        public static List<Service> services = DBConnection.dbe.Service.ToList();
        public MainPage()
        {
            InitializeComponent();
            services.ForEach(x => x.DurationInSeconds = x.DurationInSeconds / 60);
            services.ForEach(x => x.Cost = Convert.ToInt32(x.Cost));
            services.ForEach(x => x.Discount = x.Discount * 100);

            ItemsLV.ItemsSource = services;
        }
    }
}
