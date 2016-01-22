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
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;
using HotelOrigin.Core.Domian;
namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationsWindow.xaml
    /// </summary>
    public partial class ReservationsWindow : Window
    {
        private Reservation currentselecteditems = null;
        public ReservationsWindow()
        {
            InitializeComponent();
            ResvdataGrid.ItemsSource = ReservationRepository.GetAll();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddReservationWin reserviationAddingScreen = new AddReservationWin();
            reserviationAddingScreen.ShowDialog();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ReservationRepository.Delete(currentselecteditems.ID);
        }

private void ResvdataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                currentselecteditems = (Reservation)ResvdataGrid.SelectedItem;

            }
            catch { }
        }
    }
}
