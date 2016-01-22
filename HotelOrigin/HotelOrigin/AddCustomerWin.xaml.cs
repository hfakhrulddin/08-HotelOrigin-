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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
     
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string strId = id_txb.Text;
                int intId = int.Parse(strId);
                CustomerRepository.Create(intId, firstName_txb.Text, lastName_txb.Text, email_txb.Text, tele_txb.Text);

                id_txb.Clear();
                firstName_txb.Clear();
                lastName_txb.Clear();
                email_txb.Clear();
                tele_txb.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Enter an intger ID number. Your " + ex.Message);
            }
            finally

            {



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
