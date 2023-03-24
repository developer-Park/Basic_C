using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entity
{
    internal class Room
    {
        int roomNumber { get; }
        String roomName { get; }
        int roomPrice { get; }

        public Room(int roomNumber, String roomName, int roomPrice)
        {
            this.roomNumber = roomNumber;
            this.roomName = roomName;
            this.roomPrice = roomPrice;
        }

        public int RoomNumber() { 
        return roomNumber;
        }
       

    }
}
