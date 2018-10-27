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

namespace Holiday.Pages.HR
{
    /// <summary>
    /// Логика взаимодействия для BuisnessTripApp.xaml
    /// </summary>
    public partial class BuisnessTripApp : Page
    {
        ModelHoliday db = new ModelHoliday();
        public BuisnessTripApp()
        {
            InitializeComponent();
            lvListApp.ItemsSource = db.tbl_ApplicationData.Where(w => w.LeaveTypeId == 2).ToList();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            tbl_ApplicationData dat = (tbl_ApplicationData)lvListApp.SelectedItem;

            var data = db.tbl_ApplicationData.Find(dat.Application_No);
            if(data!=null)
            {
                data.ApplicationDescription = "Confirm***";
                db.SaveChanges();
            }
            lvListApp.ItemsSource = db.tbl_ApplicationData.Where(w => w.LeaveTypeId == 2).ToList();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            tbl_ApplicationData dat = (tbl_ApplicationData)lvListApp.SelectedItem;

            var data = db.tbl_ApplicationData.Find(dat.Application_No);
            if (data != null)
            {
                data.ApplicationDescription = "reject";
                db.SaveChanges();
            }
            lvListApp.ItemsSource = db.tbl_ApplicationData.Where(w => w.LeaveTypeId == 2).ToList();
        }
    }
}
