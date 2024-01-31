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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        personTableAdapter person = new personTableAdapter();
        public Page3()
        {
            InitializeComponent();
            personDTG.ItemsSource = person.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            person.InsertQuery(login.Text, Password.Text,Dolg.Text);
            personDTG.ItemsSource = person.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(personDTG.SelectedItem as DataRowView).Row[0];
            person.DeleteQuery(id);
            personDTG.ItemsSource = person.GetData();
        }
    }
}
