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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        DeliveryTableAdapter delivery = new DeliveryTableAdapter();
        public Page6()
        {
            InitializeComponent();
            DeliveryDTG.ItemsSource = delivery.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            delivery.InsertQuery(Convert.ToInt16(Time.Text), Adress.Text);
            DeliveryDTG.ItemsSource = delivery.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (int)(DeliveryDTG.SelectedItem as DataRowView).Row[0];
            delivery.DeleteQuery(id);
            DeliveryDTG.ItemsSource = delivery.GetData();
        }
    }
}
