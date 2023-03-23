using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entity
{
    internal class Booking
    {
        int roomNumber { get; }
        String roomName { get; }
        String userName { get; }
        int roomPrice { get; }

        public Booking(int roomNumber, String roomName, String userName, int roomPrice)
        {
            this.roomNumber = roomNumber; 
            this.roomName = roomName;
            this.userName = userName;
            this.roomPrice = roomPrice;
        }


    }
}
