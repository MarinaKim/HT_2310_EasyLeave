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

namespace Holiday
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame cframe;
        public static Menu menu;
        public MainWindow()
        {
            InitializeComponent();
            fCentral.Source = new Uri(@"Pages/HomePage.xaml", UriKind.RelativeOrAbsolute);
            cframe = fCentral;
            menu = MainMenu;
        }

        private void miLogOn_Click(object sender, RoutedEventArgs e)
        {
            fCentral.Source = new Uri(@"Pages/LogOnPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
