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
using HotelOrigin.Core.Repository;
using HotelOrigin.Core.Domian;
using HotelOrigin.Core;


namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private Customer currentselecteditems = null;
        public CustomerWindow()
        {
            InitializeComponent();
            CdataGrid.ItemsSource = CustomerRepository.GetAll();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer customerAddingScreen = new AddCustomer();
            customerAddingScreen.ShowDialog();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            CustomerRepository.Delete(currentselecteditems.ID);
        }

        private void CdataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                currentselecteditems = (Customer)CdataGrid.SelectedItem;
            }
            catch { }

        }
    }
}
