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
    /// Interaction logic for RoomsWindow.xaml
    /// </summary>
    public partial class RoomsWindow : Window
    {
        private Room currentselecteditems = null;
        public RoomsWindow()
        {
            InitializeComponent();
            RdataGrid.ItemsSource = RoomRepository.GetAll();
        }

        private void AddRoom_Click(object sender, RoutedEventArgs e)
        {
            AddRoomWin roomAddingScreen = new AddRoomWin();
            roomAddingScreen.ShowDialog();
        }

        private void RdataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            currentselecteditems = (Room)RdataGrid.SelectedItem;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RoomRepository.Delete(currentselecteditems.ID);
            }
            catch

            { }
        }
    }
}
