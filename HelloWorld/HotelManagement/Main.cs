// See https://aka.ms/new-console-template for more information
using HotelManagement.Service;


//Add Hotel
HotelService hotelService = new HotelService();
Console.Write("what's your hotel name? ");
String hotelName = Console.ReadLine();

Console.Write("what's your hotel password? ");
String password = Console.ReadLine();
String successAddHotel = hotelService.addHotel(hotelName, password);
Console.WriteLine(successAddHotel);

