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
using System.Windows.Shapes;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для ZAVOtdeleniya.xaml
    /// </summary>
    public partial class ZAVOtdeleniya : Window
    {
        public ZAVOtdeleniya()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Singletone.DB.Group.ToList();
          
            Singletone.DB.People.ToList();
            
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Singletone.DB.SaveChanges();
        }
    }
}
