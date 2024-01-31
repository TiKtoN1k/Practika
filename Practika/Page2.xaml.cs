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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        ProductTableAdapter product = new ProductTableAdapter();
        ShopTableAdapter shop = new ShopTableAdapter();
        public Page2()
        {
            InitializeComponent();
            PRODUCTDTG.ItemsSource = product.GetData();
            Shop.ItemsSource = shop.GetData();
            Shop.DisplayMemberPath = "Name";
            Shop.SelectedValuePath = "id_Shop";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(PRODUCTDTG.SelectedItem as DataRowView).Row[0];
            product.DeleteQuery(id);
            PRODUCTDTG.ItemsSource = product.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            product.InsertQuery(Product_name.Text, Convert.ToInt32(Price.Text), (int)Shop.SelectedValue);
            PRODUCTDTG.ItemsSource = product.GetData();
        }
    }
}
