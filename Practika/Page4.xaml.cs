using Practika.zakazi_UZDDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        ShopTableAdapter shop = new ShopTableAdapter();
        public Page4()
        {
            InitializeComponent();
            storeDTG.ItemsSource = shop.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            shop.InsertQuery(Store.Text);
            storeDTG.ItemsSource = shop.GetData();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(storeDTG.SelectedItem as DataRowView).Row[0];
            shop.DeleteQuery(id);
            storeDTG.ItemsSource = shop.GetData();
        }
    }
}
