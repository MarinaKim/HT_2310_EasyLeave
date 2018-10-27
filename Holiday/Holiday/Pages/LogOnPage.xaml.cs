using Holiday.DAL.Model;
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

namespace Holiday.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogOnPage.xaml
    /// </summary>
    public partial class LogOnPage : Page
    {
        ModelHoliday db = new ModelHoliday();
        public LogOnPage()
        {
            InitializeComponent();
            GridLogOn.DataContext = new tbl_Users();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbl_Users user = (tbl_Users)GridLogOn.DataContext;
            tbl_Users fuser = db.tbl_Users.FirstOrDefault(f => f.UserName == user.UserName 
            && f.Password==user.Password);
            if (fuser != null)
            {
                MainWindow.cframe.Source = new Uri(@"Pages/AdminHomePage.xaml", UriKind.RelativeOrAbsolute);
                MenuItem item = new MenuItem() { Header = "Admin" };

                var AddUserMenuItem = new MenuItem() { Header = "Add user" };
                AddUserMenuItem.Click += AddUser_Click;
                item.Items.Add(AddUserMenuItem);

                var ListUsersMenuItem = new MenuItem() { Header = "List of users" };
                ListUsersMenuItem.Click += ListUsers_Click;
                item.Items.Add(ListUsersMenuItem);         
                
                MainWindow.menu.Items.Add(item);

            }
            else
            {
                lError.Content = "Incorrect Login or Password";
                //MessageBox.Show("Incorrect Login or Password");
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cframe.Source = new Uri(@"Pages/AddUserPage.xaml", UriKind.RelativeOrAbsolute);
        }
        private void ListUsers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cframe.Source = new Uri(@"Pages/ListUserPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
