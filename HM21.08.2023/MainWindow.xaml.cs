using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using UserClass;

namespace HM21._08._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GuestManager manager = null;
        public MainWindow()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
            manager = new(connStr);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = manager.GetAdmins();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = manager.GetAllGuests();
        }
    }
}
