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
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
namespace HotelOrigin
{
    /// <summary>
    /// Interaction logic for AddReservationWin.xaml
    /// </summary>
    public partial class AddReservationWin : Window
    {
        public AddReservationWin()
        {
            InitializeComponent();
            ObservableCollection<Customer> AllCustomers = CustomerRepository.GetAll();

           for (int x = 0; x < AllCustomers.Count; x++)
            {
                Customer_cbo.Items.Add(AllCustomers[x].FirstName);
            }

            ObservableCollection<Room> roomsloaded = RoomRepository.GetAll();

            for (int i = 0; i < roomsloaded.Count; i++)
            {
            Room_cbo.Items.Add(roomsloaded[i].RoomNumber);
            }

        }
        private void SubmitReservation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string strId = reservation_id_txb.Text;
                int intId = int.Parse(strId);

                string strRoomNo = ceckin_databox.Text;
                DateTime Checkintime = DateTime.Parse(strRoomNo);

                string strId5 = ceckout_databox.Text;
                DateTime CheckoutTime = DateTime.Parse(strId5);

                string customerReservationId = Customer_cbo.Text.ToString();
                int roomReservationId = int.Parse(Room_cbo.Text.ToString());

                ReservationRepository.Create(intId, customerReservationId, roomReservationId, Checkintime, CheckoutTime);

                reservation_id_txb.Clear();
                ceckin_databox.Text = null;
                ceckout_databox.Text = null;

                Customer_cbo.Text = null;
                Room_cbo.Text = null;
            }



            catch (Exception ex)
            {
                MessageBox.Show("Enter a right value. Your " + ex.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomerRepository.Save();
            ReservationRepository.Save();
            RoomRepository.Save();
        }
    }
}
