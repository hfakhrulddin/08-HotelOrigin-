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
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;
using HotelOrigin.Core.Domian;

namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CustomerRepository.Upload();
            ReservationRepository.Upload();
            RoomRepository.Upload();
        }

        private void Reservations_Click(object sender, RoutedEventArgs e)
        {
            ReservationsWindow ReservatinsWin = new ReservationsWindow();
            ReservatinsWin.ShowDialog();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow CustomersWin = new CustomerWindow();
            CustomersWin.ShowDialog();
        }

        private void Rooms_Click(object sender, RoutedEventArgs e)
        {
            RoomsWindow RoomsWin = new RoomsWindow();
            RoomsWin.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomerRepository.Save();
            ReservationRepository.Save();
            RoomRepository.Save();
        }
    }
}
