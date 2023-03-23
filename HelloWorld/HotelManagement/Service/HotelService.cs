using HotelManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service
{
    internal class HotelService
    {
        List<Room> rooms = new List<Room>();

        public string addHotel(String hotelName, String hotelPassword) {
            Hotel hotel = new Hotel(hotelName,hotelPassword);
            return "sucess add Hotel";
        }

        public List<Room> addRoom()
        {
            Room singleroom = new Room(101, "single", 500);
            Room singleroom1 = new Room(102, "single", 500);
            Room singleroom2 = new Room(103, "single", 500);
            Room queenroom = new Room(201, "queen", 1000);
            Room queenroom1 = new Room(202, "queen", 1000);
            Room queenroom2 = new Room(203, "queen", 1000);
            Room queenroom3 = new Room(204, "queen", 1000);
            Room kingroom = new Room(301, "king", 2000);
            Room kingroom1 = new Room(302, "king", 2000);
            Room kingroom2 = new Room(303, "king", 2000);

            rooms.Add(singleroom);
            rooms.Add(singleroom1);
            rooms.Add(singleroom2);
            rooms.Add(queenroom);
            rooms.Add(queenroom1);
            rooms.Add(queenroom2);
            rooms.Add(queenroom3);
            rooms.Add(kingroom);
            rooms.Add(kingroom1);
            rooms.Add(kingroom2);
            Console.WriteLine("Success add room.");
            return rooms;
        }

        public string getRoomList()
        {
           
            return "sucess add Hotel";
        }

    }
}
