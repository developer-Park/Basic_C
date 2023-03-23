using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entity
{
    internal class Hotel
    {
        String hotelName { get;}
        String hotelPassword { get; }
        List<Room> room { get; }
        public Hotel(String hotelName, String hotelPassword)
        {
            this.hotelName = hotelName;
            this.hotelPassword = hotelPassword;
            this.room = new List<Room>();
        }

        public Hotel() { }
    }
}
