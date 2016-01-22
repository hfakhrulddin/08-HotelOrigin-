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
    /// Interaction logic for AddRoomWin.xaml
    /// </summary>
    public partial class AddRoomWin : Window
    {
        public AddRoomWin()
        {
            InitializeComponent();
        }

        private void AddRoomSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string strId = Room_id_txb.Text;
                int intId = int.Parse(strId);

                string strRoomNo = Room_No_txb.Text;
                int intId2 = int.Parse(strRoomNo);

                string strId3 = Room_NoB_txb.Text;
                int intId3 = int.Parse(strId3);
                hasTv_cbx.IsChecked = null;
                bool HasTvBool;
                if (hasTv_cbx.IsChecked == true)
                    { HasTvBool = true; }
                else
                { HasTvBool = false; }

                RoomRepository.Create(intId, intId2, intId3, HasTvBool);

                Room_id_txb.Clear();
                Room_No_txb.Clear();
                Room_NoB_txb.Clear();

                //hasTv_cbx.IsChecked = null;
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enter an intger ID number. Your " + ex.Message);
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
