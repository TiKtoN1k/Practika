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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        OrdersTableAdapter  order = new OrdersTableAdapter();
        ProductTableAdapter product= new ProductTableAdapter();
        DeliveryTableAdapter delivery= new DeliveryTableAdapter();
        public Page5()
        {
            InitializeComponent();
            ZakazDTG.ItemsSource = order.GetData();
            Product.ItemsSource = product.GetData();
            Product.DisplayMemberPath = "Product_name";
            Product.SelectedValuePath = "Product_id";
            Delivery.ItemsSource = delivery.GetData();
            Delivery.DisplayMemberPath = "Delivery_time";
            Delivery.SelectedValuePath = "Delivery_id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            order.InsertQuery((int)Product.SelectedValue,(int)Delivery.SelectedValue);
            ZakazDTG.ItemsSource = order.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (int)(ZakazDTG.SelectedItem as DataRowView).Row[0];
            order.DeleteQuery(id);
            ZakazDTG.ItemsSource = order.GetData();
        }

    }
}
