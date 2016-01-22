using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domian;
using HotelOrigin.Core;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
namespace HotelOrigin.Core.Repository
{
    public class RoomRepository
    {
        private static ObservableCollection<Room> rooms = new ObservableCollection<Room>();
        //Create
        public static Room Create(int id, int roomNumber, int numbersOfbed, bool hasTV)
        {
            Room room = new Room();

            room.ID = id;
            room.RoomNumber = roomNumber;
            room.NumberOfBeds = numbersOfbed;
            room.HasTv = hasTV;
            rooms.Add(room);


            return room;
        }
        //Read
        public static Room GetById(int id)
        {
            return rooms.FirstOrDefault(c => c.ID == id);
        }
        //Read All
        public static ObservableCollection<Room> GetAll()
        {
            return rooms;
        }
        //Update
        public static void Update(Room room, int id, int roomNumber, int numbersOfbed, bool hasTV)
        {
            room.ID = id;
            room.RoomNumber = roomNumber;
            room.NumberOfBeds = numbersOfbed;
            room.HasTv = hasTV;
        }
        //Delete
        public static void Delete(int id)
        {
            var room = GetById(id);
            rooms.Remove(room);
        }
        //Upload
        public static void Upload()
        {

            if (File.Exists("RoomsList.Json"))
            {
                string JsonRoomsList = File.ReadAllText("RoomsList.Json");
                ObservableCollection<Room> roomsloaded = JsonConvert.DeserializeObject<ObservableCollection<Room>>(JsonRoomsList);
                rooms = roomsloaded;
            }
        }
        //Save
        public static void Save()
        {
            string JsonCustomersList = JsonConvert.SerializeObject(rooms);
            File.WriteAllText("RoomsList.Json", JsonCustomersList);
        }
    }
}
