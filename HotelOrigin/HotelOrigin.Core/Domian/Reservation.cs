using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Domian
{
    public class Reservation
    {
        public int ID { get; set; }
        public string customer { get; set; }
        public int room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
       
    }
}
