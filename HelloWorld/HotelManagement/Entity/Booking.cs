using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        String roomSize { get; }
        DateTime bookignDate { get; }

        public Booking(BookingRequestDTO bookigRequestDTO)
        {
            this.roomNumber = bookigRequestDTO.getRoomNumber();
            this.userName = bookigRequestDTO.getUserName();
            this.roomPrice = bookigRequestDTO.getRoomPrice();
            this.bookignDate = bookigRequestDTO.getBookigDate();

        }

        public int getRoomNumber() { return roomNumber; }
        public String getRoomName() { return roomName; }
        public int getRoomPrice() { return roomPrice; }
        public String getRoomSize() { return roomSize; }
        public DateTime getBookignDate() { return bookignDate; }
        public String getUsername() { return userName; }
    }
}
