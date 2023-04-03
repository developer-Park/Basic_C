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
        String roomSize { get; }
        int roomPrice { get; }

        bool isBooked { get; set; }
        DateTime bookingDate { get; set; }

        public Room(int roomNumber, String roomSize, int roomPrice)
        {
            this.roomNumber = roomNumber;
            this.roomSize = roomSize;
            this.roomPrice = roomPrice;
            this.isBooked = false;
        }

        public int getRoomNumber() { 
        return roomNumber;
        }
       
        public String getRoomSize()
        {
            return roomSize;
        }

        public int getRoomPrice() {
            return roomPrice;

        }
        public bool IsBooked()
        {
            return isBooked;
        }

        public void changeBookStatus()
        {
            this.isBooked = true;
        }

        public void changeBookStatusFalse()
        {
            this.isBooked = false;
        }

        public DateTime getBookingDate()
        {
            return bookingDate;
        }

    }
}
