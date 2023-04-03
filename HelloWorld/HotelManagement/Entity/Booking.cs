using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

namespace HotelManagement.Entity
{
    internal class Booking
    {
        String bookingNum { get; }
        int roomNumber { get; }
        String roomName { get; }
        String userName { get; }
        int roomPrice { get; }
        String roomSize { get; }
        DateTime bookignDate { get; }

        bool isDelated { get; set; }

        public Booking(BookingRequestDTO bookigRequestDTO)
        {

            Guid myUUId = Guid.NewGuid();
            string convertedUUID = myUUId.ToString();
            this.bookingNum = convertedUUID;
            this.roomNumber = bookigRequestDTO.getRoomNumber();
            this.roomSize = bookigRequestDTO.getRoomSize();
            this.userName = bookigRequestDTO.getUserName();
            this.roomPrice = bookigRequestDTO.getRoomPrice();
            this.bookignDate = bookigRequestDTO.getBookigDate();
            this.isDelated = false;
        }
        public String getBookingNumber()
        {
            return bookingNum;
        }

        public bool isDeleted() { 
        return isDelated;
        }

        public int getRoomNumber() { return roomNumber; }
        public String getRoomName() { return roomName; }
        public int getRoomPrice() { return roomPrice; }
        public String getRoomSize() { return roomSize; }
        public DateTime getBookignDate() { return bookignDate; }
        public String getUsername() { return userName; }
        public void deleteBooking()
        {
            this.isDelated = true;
        
        }
    }
}
