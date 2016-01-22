using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domian;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace HotelOrigin.Core.Repository
{
    public class ReservationRepository
    {
        private static ObservableCollection<Reservation> reservations = new ObservableCollection<Reservation>();
        //Create
        public static Reservation Create(int id, string customer, int room, DateTime checkin, DateTime checkout)
        {
            Reservation reservation = new Reservation();

            reservation.ID = id;
            reservation.customer = customer;
            reservation.room = room;
            reservation.CheckInDate = checkin;
            reservation.CheckOutDate = checkout;


            reservations.Add(reservation);
            return reservation;
        }
        //Read
       public static Reservation GetById(int id)
        {
            return reservations.FirstOrDefault(c => c.ID == id);
        }
        //Read All
        public static ObservableCollection<Reservation> GetAll()
        {
            return reservations;
        }
        //Update
        public static void Update(Reservation reservation, int id, string customer, int room, DateTime checkin, DateTime checkout)
        {
            reservation.ID = id;
            reservation.customer = customer;
            reservation.room = room;
            reservation.CheckInDate = checkin;
            reservation.CheckOutDate = checkout;
        }
        //Delete
        public static void Delete(int id)
        {
            var reservation = GetById(id);
            reservations.Remove(reservation);
        }
        //Upload
        public static void Upload()
        {
            if (File.Exists("ReservationsList.Json"))
            {
                string JsonReservationsList = File.ReadAllText("ReservationsList.Json");
                ObservableCollection<Reservation> reservationsloaded = JsonConvert.DeserializeObject<ObservableCollection<Reservation>>(JsonReservationsList);
                reservations = reservationsloaded;
            }
        }
        //Save
        public static void Save()
        {
            string JsonReservationsList = JsonConvert.SerializeObject(reservations);
            File.WriteAllText("ReservationsList.Json", JsonReservationsList);
        }
    }
}
