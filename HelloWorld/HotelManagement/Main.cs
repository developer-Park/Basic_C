// See https://aka.ms/new-console-template for more information
using HotelManagement.Entity;
using HotelManagement.Service;
using System;
using System.Runtime.Serialization;

UserService userService = new UserService();

//Add Hotel
HotelService hotelService = new HotelService();
Console.Write("what's your hotel name? ");
String hotelName = Console.ReadLine();

Console.Write("what's your hotel password? ");
String hotelPassword = Console.ReadLine();
String successAddHotel = hotelService.addHotel(hotelName, hotelPassword);
Console.WriteLine(successAddHotel);

//Add Room
var romms = hotelService.addRoom();




while (true)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("");
    Console.WriteLine("1.Add User");
    Console.WriteLine("2.User Login");


    string inp = Console.ReadLine();
    int a;
    Int32.TryParse(inp, out a);
    if (a == 1)
    {
        Console.WriteLine("Username : ");
        String username = Console.ReadLine();
        Console.WriteLine("User password :");
        String userPaswword = Console.ReadLine();
        userService.addUser(username, userPaswword);
    }
    else if (a == 2)
    {
        Console.WriteLine("Login ID : ");
        String username = Console.ReadLine();
        Console.WriteLine("Login Password : ");
        String userPaswword = Console.ReadLine();
        User user = userService.Login(username, userPaswword);
        if (user !=null)
        {

            while (true)
            {
                Console.WriteLine("3.Get user info");
                Console.WriteLine("4.Make a booking");
                Console.WriteLine("5.Check my booking list"); 
                Console.WriteLine("6.Check my booking by booking number"); //get a reservation // using reservation number
                Console.WriteLine("7.Cancel the reservation");// cancel reservation list // using reservation number
                Console.WriteLine("8.exit");
                Console.WriteLine("Input Number");
                string input = Console.ReadLine();
                int b;
                Int32.TryParse(input, out b);
                if (b == 3)
                {
                    userService.getUserInfo(user);
                }
                else if (b == 4)
                {
                    Console.WriteLine("Available Room List");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Enter reservation date format : MM/DD/YY");
                    String reservationDate = Console.ReadLine();
                    DateTime dt = Convert.ToDateTime(reservationDate);
                    hotelService.getRoomList(romms, dt);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Enter room number : ");
                    String roomNumber = Console.ReadLine();
                    int roomNo;
                    Int32.TryParse(roomNumber, out roomNo);



                    hotelService.makeBooking(roomNo, user.getUserName(), dt);
                }
                else if (b == 5)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Check my booking list");
                    hotelService.getBookingList(user.getUserName());
                }
                else if (b == 6)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Check my booking by booking number");
                    string bookingNumber = Console.ReadLine();
                    hotelService.getBooking(bookingNumber);
                }
                else if (b == 7)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Cancel the booking");
                    Console.WriteLine("Put the bookingNumber for cancel");
                    string bookingNumber = Console.ReadLine();
                    hotelService.deleteBooking(bookingNumber);
                    Console.WriteLine("Sucess cancel the booking");
                }
                else if (b==8) {
                    break;
                }
            }
        }
    }
}
