using HotelManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    internal class BookingRequestDTO
    {
        int roomNumber { get; }
        String roomSize { get; }
        String userName { get; }
        int roomPrice { get; }
        DateTime bookigDate { get; }
        public BookingRequestDTO(Room room, String username, DateTime date) {
            this.roomNumber = room.getRoomNumber();
            this.roomSize = room.getRoomSize();
            this.userName = username;
            this.roomPrice = room.getRoomPrice();
            this.bookigDate = date;
        }

        public int getRoomNumber() {  return roomNumber; }
        public String getRoomName() {  return roomSize; }
        public String getUserName() { return userName; }    
        public int getRoomPrice() {  return roomPrice; }
        public String getRoomSize() {  return roomSize; }
        public DateTime getBookigDate() {  return bookigDate; }

    }
}
